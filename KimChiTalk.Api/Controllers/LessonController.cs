using KimChiTalk.Extensions;
using KimChiTalk.Repository.Entity;
using KimChiTalk.Service.Lesson;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/lesson")]
public class LessonController: ControllerBase
{
    private readonly IService _lessonService;
    public LessonController(IService lessonService)
    {
        _lessonService = lessonService;
    }

    [HttpGet]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> GetLessons( Guid courseId)
    {
        var userId = GetCurrentUserId();
        var result = await _lessonService.GetLessons(userId!.Value, courseId);
        return Ok(result);
    }
    private Guid? GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return Guid.TryParse(value, out var id) ? id : null;
    }

    [HttpPost]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> CreateLesson(Request.LessonRequest request)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)
        {
            return Unauthorized();
        }

        await _lessonService.CreateLesson(adminId.Value, request);
        return NoContent();
    }

    [HttpPut("{lessonId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> UpdateLesson(Request.LessonRequest request, Guid lessonId)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)
        {
            return Unauthorized();
        }
        await _lessonService.UpdateLesson(adminId.Value,request, lessonId);
        return NoContent();
        
    }

    [HttpDelete("{lessonId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> DeleteLesson(Guid lessonId)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)
        {
            return Unauthorized();
        }
        await _lessonService.DeleteLesson(adminId.Value, lessonId);
        return NoContent();
    }
    
}