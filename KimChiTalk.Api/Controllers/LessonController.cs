using KimChiTalk.Extensions;
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
}