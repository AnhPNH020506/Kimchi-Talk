using System.Security.Claims;

namespace KimChiTalk.Service.JWTService;

public interface IService
{
    public string GenerateAccessToken(IEnumerable<Claim> claims);
    ClaimsPrincipal? ValidateToken(string token, bool validateLifetime = true);
}