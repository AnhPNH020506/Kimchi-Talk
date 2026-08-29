using KimChiTalk.Extensions;
using KimChiTalk.Service.Vocabulary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/vocabulary")]
public class VocabularyController: ControllerBase
{
    private readonly IService _vocabularyService;

    public VocabularyController(IService service)
    {
        _vocabularyService = service;
    }

    [HttpGet()]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> GetVocabularies( Guid lessonId)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
            return BadRequest();
        var result = await _vocabularyService.GetVocabularies(userId!.Value, lessonId);
        return Ok(result);
    }
    private Guid? GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return Guid.TryParse(value, out var id) ? id : null;
    }

    [HttpPatch("{vocabularyId}")]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> UpdateVocabularyAsLearned(Guid vocabularyId)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
        {
            return BadRequest();
        }

        await _vocabularyService.MarkVocabularyAsLearned(userId!.Value, vocabularyId);
        return NoContent();
        
    }
}