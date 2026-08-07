namespace KimChiTalk.Service.Identity;

public interface IService
{
    public Task<Response.IdentityResponse> LoginRequest(Request.LoginRequest request);
    public Task<string>Register(Request.RegisterRequest request);
    public Task<Response.IdentityResponse> RefreshTokenRequest(Request.RefreshTokenRequest request);
    
}