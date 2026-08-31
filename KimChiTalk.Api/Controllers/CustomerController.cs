using KimChiTalk.Extensions;
using KimChiTalk.Service.Message;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/customer")]
public class CustomerController:ControllerBase
{
    private readonly IService _messageService;
    public CustomerController(IService messageService)
    {
        _messageService = messageService;
    }

    [HttpGet("message")]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> GetMessages()
    {
        var userId = GetCurrentUserId();
        var result = await _messageService.GetMessageForCustomer(userId!.Value);
        return Ok(result);
    }
    private Guid? GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return Guid.TryParse(value, out var id) ? id : null;
    }

    [HttpPatch("{messageId}")]
    [Authorize(Policy = JwtExtensions.CustomerPolicy)]
    public async Task<IActionResult> UpdateMessageIsRead([FromRoute] Guid messageId)
    {
        var userId = GetCurrentUserId();
        if (userId == null)
        {
            return BadRequest();
        }

        await _messageService.MarkMessageAsRead(userId!.Value, messageId );
        return NoContent();
    }
}