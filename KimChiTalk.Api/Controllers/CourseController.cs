using KimChiTalk.Extensions;
using KimChiTalk.Repository.Entity;
using KimChiTalk.Service.Course;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;

[ApiController]
[Route("api/v1/course")]
public class CourseController : ControllerBase
{
    private readonly IService _courseService; 
    public  CourseController(IService courseService)
    {
        _courseService = courseService;
    }
    [HttpGet()]
    public async Task<IActionResult> GetCourses()
    {
        var userId = GetCurrentUserId();
        var result = await _courseService.GetCourses(userId);
        return Ok(result);
    }

    [HttpPost("{courseId}/enroll")]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> EnrollCourse(Guid courseId)
    {
        var userId = GetCurrentUserId();
        var result = await _courseService.Enroll(userId!.Value, courseId);
        return Ok(result);
    }
    private Guid? GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return Guid.TryParse(value, out var id) ? id : null;
    }

    [HttpPost]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> CreateCourse(Request.CourseRequest request)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
        {
            return BadRequest();
        }
        await _courseService.CreateCourse(userId.Value, request);
        return NoContent();
    }

    [HttpPatch("{courseId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> UpdateCourse(Guid courseId, Request.CourseRequest request)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
        {
            return BadRequest();
        }
        await _courseService.UpdateCourse(userId.Value, courseId, request);
        return NoContent();
    }

    [HttpDelete("{courseId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> DeleteCourse(Guid courseId)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
        {
            return BadRequest();
        }
        await _courseService.DeleteCourse(userId.Value, courseId);
        return NoContent();
    }
}