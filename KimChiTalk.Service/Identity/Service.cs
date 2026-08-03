using KimChiTalk.Repository.Entity;
using KimChiTalk.Service.JWTService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto.Generators;

namespace KimChiTalk.Service.Identity;
using KimChiTalk.Repository;
public class Service : IService
{
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
}