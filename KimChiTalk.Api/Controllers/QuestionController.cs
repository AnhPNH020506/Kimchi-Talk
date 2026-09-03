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

    [HttpPost("create")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> CreateQuestion(Request.QuestionRequest request)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)
        {
            return BadRequest();
        }
        await _questionService.CreateQuestions(adminId!.Value, request);
        return NoContent();
    }

    [HttpPatch("{questionId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> UpdateQuestion(Guid questionId, Request.QuestionRequest request)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)
        {
            return BadRequest();
        }
        await _questionService.UpdateQuestions(adminId.Value, questionId, request);
        return NoContent();
    }

    [HttpDelete("{questionId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> DeleteQuestion(Guid questionId)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)
        {
            return BadRequest();
        }
        await _questionService.DeleteQuestions(adminId.Value, questionId);
        return NoContent();
    }
}