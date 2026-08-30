using KimChiTalk.Extensions;
using KimChiTalk.Service.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;
[ApiController]
[Route("api/v1/admin")]
public class AdminController: ControllerBase
{
    private readonly IService _userService;
    public AdminController(IService userService)
    {
        _userService = userService;
    }

    [HttpGet("customers/{userId}/process")]
    [Authorize(Policy = JwtExtensions.AdminPolicy)]
    public async Task<IActionResult> GetCustomerProgress(Guid userId)
    {
        var result = await _userService.CourseProgress(userId);
        return Ok(result);
    }
   
}

