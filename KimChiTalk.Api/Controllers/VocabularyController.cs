using KimChiTalk.Extensions;
using KimChiTalk.Repository.Entity;
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

    [HttpGet("{vocabularyId}")]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> GetVocabularyById(Guid vocabularyId)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
        {
            return BadRequest();
        }

        var result = await _vocabularyService.GetVocabularyById(userId!.Value, vocabularyId);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> CreateVocabulary(Request.VocabularyRequest request)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)

        {
            return BadRequest();
        }

        await _vocabularyService.CreateVocabulary(adminId.Value, request);
        return NoContent();
    }

    [HttpDelete("{vocabularyId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> DeleteVocabulary(Guid vocabularyId)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)

        {
            return BadRequest();
        }
        await _vocabularyService.DeleteVocabulary(adminId.Value, vocabularyId);
        return NoContent();
    }

    [HttpPatch("{vocabularyId}")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> UpdateVocabulary(Guid vocabularyId, Request.VocabularyRequest request)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)

        {
            return BadRequest();
        }
        await _vocabularyService.UpdateVocabulary(adminId.Value, vocabularyId, request);
        return NoContent();
    }
    
    
}