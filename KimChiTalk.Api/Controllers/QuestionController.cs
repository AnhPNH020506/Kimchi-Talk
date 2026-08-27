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
}