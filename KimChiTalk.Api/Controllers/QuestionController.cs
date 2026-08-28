using KimChiTalk.Extensions;
using KimChiTalk.Repository.Entity;
using KimChiTalk.Service.Question;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/question")]
public class QuestionController: ControllerBase
{
    private readonly IService _questionService;
    public QuestionController(IService questionService)
    {
        _questionService = questionService;
    }

    [HttpGet]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public  async Task<IActionResult> GetQuestions(Guid lessonId, QuestionStage questionStage)
    {
        var result = await _questionService.GetQuestions(lessonId, questionStage);
        return Ok(result);
    }

    [HttpPost("")]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> SubmitQuestions(Request.SubmitQuestionRequest request)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            {
            return BadRequest();
            }
        var result = await _questionService.SubmitQuestions(request, userId!.Value);
        return Ok(result);
    }
    private Guid? GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return Guid.TryParse(value, out var id) ? id : null;
    }
}