using KimChiTalk.Extensions;
using KimChiTalk.Service.Grammar;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/grammar")]
public class GrammarController: ControllerBase
{
    private readonly IService _grammarService;
    public GrammarController(IService grammarService)
    {
        _grammarService = grammarService;
    }

    [HttpGet]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> GetGrammars(Guid lessonId)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            {
            return BadRequest();
            }
        var result = await _grammarService.GetGrammars(userId!.Value, lessonId);
        return Ok(result);
    }
    private Guid? GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return Guid.TryParse(value, out var id) ? id : null;
    }

    [HttpGet("{grammarId}")]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> GetGrammarById(Guid grammarId)
    {
        var user = GetCurrentUserId();
        if (user == null)
        {
            return BadRequest();
        }
        var result = await _grammarService.GetGrammarById(user!.Value, grammarId);
        return Ok(result);
    }
}