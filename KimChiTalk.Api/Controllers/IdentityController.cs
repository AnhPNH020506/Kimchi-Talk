using KimChiTalk.Service.Identity;
using KimChiTalk.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace KimChiTalk.Controllers;

[ApiController]
[Route("api/v1/auth")]
public class IdentityController: ControllerBase
{
    private readonly IService _identityService;
    public IdentityController(IService identityService)
    {
        _identityService = identityService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> login([FromBody] Request.LoginRequest request)
    {
        var result = await _identityService.LoginRequest(request);
        return Ok(ApiResponseFactory.SuccessResponse(result, "Login Successful", HttpContext.TraceIdentifier));
    }
}