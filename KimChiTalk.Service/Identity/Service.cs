using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using KimChiTalk.Repository.Entity;
using KimChiTalk.Service.JWTService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto.Generators;

namespace KimChiTalk.Service.Identity;
using KimChiTalk.Repository;
public class Service : IService
{
    private const string AccessTokenType = "access";
    private const string TokenTypeClaim = "TokenType";
    
    private readonly AppDbContext _dbContext;
    private readonly JwtOptions _jwtOptions;
    private readonly JWTService.IService _jwtService;
    public Service(AppDbContext dbContext, IOptions<JwtOptions> jwtOptions,
        JWTService.IService jwtService)
    {
        _dbContext = dbContext;
        _jwtOptions = jwtOptions.Value;
        _jwtService = jwtService;
    }
    public async Task<Response.IdentityResponse> LoginRequest(Request.LoginRequest request)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
        if (user == null)
        {
            throw new KeyNotFoundException("User not found");
        }

        if (!BCrypt.Net.BCrypt.Verify(request.Password, user.HashshedPassword))
        {
            throw new UnauthorizedAccessException("Invalid password");
        }
         return await BuildTokenPairAsync(user);
    }

    private async Task<Response.IdentityResponse> BuildTokenPairAsync(Repository.Entity.User user,
        UserRefreshToken? tokenToRevoke = null)
    {
        var accessToken = await BuildAccessTokenAsync(user);
        var refreshToken = GenerateRefreshToken();
        var refreshTokenhash = HashRefreshToken(refreshToken);
        var refreshTokenExpiresAtUtc = DateTimeOffset.UtcNow.AddDays(_jwtOptions.RefreshTokenExpireDays);

        if (tokenToRevoke != null)
        {
            tokenToRevoke.RevokedAtUtc = DateTime.UtcNow;
            tokenToRevoke.ReplacedByTokenHash = refreshTokenhash;
        }

        _dbContext.UserRefreshTokens.Add(new UserRefreshToken
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            TokenHash = refreshTokenhash,
            ExpiresAtUtc = refreshTokenExpiresAtUtc
        });
        await _dbContext.SaveChangesAsync();
        return new Response.IdentityResponse
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken,
            RefreshTokenExpiresAtUtc = refreshTokenExpiresAtUtc
        };
    }

    private async Task<string> BuildAccessTokenAsync(Repository.Entity.User user)
    {
        var claims = new List<Claim>
        {
            new("UserId", user.Id.ToString()),
            new("Email", user.Email),
            new("Name", user.Name),
            new("Role", user.Role.ToString()),
            new(TokenTypeClaim, AccessTokenType),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new(ClaimTypes.Role, user.Role.ToString()),
            new(ClaimTypes.Expired, DateTimeOffset.UtcNow.AddMinutes(_jwtOptions.ExpireMinutes).ToString())

        };
        return null;
    }
    private static string GenerateRefreshToken()
    {
        return Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
    }

    private static string HashRefreshToken(string refreshToken)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(refreshToken));
        return Convert.ToBase64String(bytes);
    }
}