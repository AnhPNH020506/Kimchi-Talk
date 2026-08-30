using KimChiTalk.Extensions;
using KimChiTalk.Service.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Request = KimChiTalk.Service.Message.Request;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/admin")]
public class AdminController: ControllerBase
{
    private readonly IService _userService;
    private readonly Service.Message.IService _messageService;
    public AdminController(IService userService, Service.Message.IService messageService)
    {
        _userService = userService;
        _messageService = messageService;
    }

    [HttpGet("customers/{userId}/process")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> GetCustomerProgress(Guid userId)
    {
        var result = await _userService.CourseProgress(userId);
        return Ok(result);
    }

    [HttpPost("messages")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> AddMessageToCustomer( [FromBody] Request.MessageRequest messageRequest)
    {
        var adminId = GetCurrentUserId();
        if (adminId == null)
        {
            return BadRequest();
        }
         await _messageService.SendMessageForCustomer(messageRequest, adminId!.Value);
        return NoContent();
    }
    private Guid? GetCurrentUserId()
    {
        var value = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        return Guid.TryParse(value, out var id) ? id : null;
    }
   
}

