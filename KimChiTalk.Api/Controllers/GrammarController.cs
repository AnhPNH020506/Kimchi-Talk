using KimChiTalk.Service.Grammar;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/vocabulary")]
public class GrammarController: ControllerBase
{
    private readonly IService _grammarService;
    public GrammarController(IService grammarService)
    {
        _grammarService = grammarService;
    }

    [HttpGet]
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
}