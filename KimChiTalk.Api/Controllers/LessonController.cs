using KimChiTalk.Service.Lesson;
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
    public async Task<IActionResult> GetLessons( Guid lessonId)
    {
        var userId = GetCurrentUserId();
        var result = await _lessonService.GetLessons(userId, lessonId);
        return Ok(result);
    }
    private Guid GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return value == null ? Guid.Empty : Guid.Parse(value);
    }
}