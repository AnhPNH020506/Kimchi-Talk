namespace KimChiTalk.Service.Identity;

public interface IService
{
    public Task<Response.IdentityResponse> LoginRequest(Request.LoginRequest request);
}