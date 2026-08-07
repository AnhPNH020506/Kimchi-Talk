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

    [HttpPost("register")]
    public async Task<IActionResult> register([FromBody] Request.RegisterRequest request)
    {
        var result = await _identityService.Register(request);
        return Ok(ApiResponseFactory.SuccessResponse(result, "Register Successful", HttpContext.TraceIdentifier));
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> refreshToken([FromBody] Request.RefreshTokenRequest request)
    {
        var result = await _identityService.RefreshTokenRequest(request);
        return Ok(ApiResponseFactory.SuccessResponse(result,  "RefreshToken Successful", HttpContext.TraceIdentifier));
    }
}