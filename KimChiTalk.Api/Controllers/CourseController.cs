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

    [HttpPost()]
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
}