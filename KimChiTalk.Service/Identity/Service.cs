using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;
using KimChiTalk.Service.JWTService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace KimChiTalk.Service.Identity;

public class Service : IService
{
    private const string AccessTokenType = "access";
    private const string TokenTypeClaim = "TokenType";

    private readonly AppDbContext _dbContext;
    private readonly JwtOptions _jwtOptions;
    private readonly JWTService.IService _jwtService;

    public Service(
        AppDbContext dbContext,
        IOptions<JwtOptions> jwtOptions,
        JWTService.IService jwtService)
    {
        _dbContext = dbContext;
        _jwtOptions = jwtOptions.Value;
        _jwtService = jwtService;
    }

    public async Task<Response.IdentityResponse> LoginRequest(Request.LoginRequest request)
    {
        // Chuan hoa email: PostgreSQL so sanh chuoi CO phan biet hoa thuong,
        // khong chuan hoa thi "Abc@gmail.com" va "abc@gmail.com" thanh 2 tai khoan khac nhau.
        var email = request.Email.Trim().ToLowerInvariant();

        var user = await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Email == email && !u.IsDeleted);

        // Gop 2 truong hop lam 1 thong bao: neu tach rieng "User not found" va
        // "Invalid password" thi ke tan cong do duoc email nao da dang ky trong he thong.
        if (user is null || !BCrypt.Net.BCrypt.Verify(request.Password, user.HashshedPassword))
        {
            throw new UnauthorizedAccessException("Email hoặc mật khẩu không đúng");
        }

        return await BuildTokenPairAsync(user);
    }

    public async Task<string> Register(Request.RegisterRequest request)
    {
        if (!System.Net.Mail.MailAddress.TryCreate(request.Email, out _))
        {
            throw new Exception("Invalid email format");
        }
        var isExistEmail = await _dbContext.Users.AnyAsync(u => u.Email == request.Email);
        if (isExistEmail)
        {
            throw new Exception("Email already exists");
        }
        
        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
        var user = new Repository.Entity.User
        {
            Email = request.Email,
            Name = request.FullName,
            HashshedPassword = hashedPassword,
            Role = UserRole.Customer,
        };
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return "Registered Successfully";

    }

    private async Task<Response.IdentityResponse> BuildTokenPairAsync(
        Repository.Entity.User user, UserRefreshToken? tokenToRevoke = null)
    {
        var accessToken = BuildAccessToken(user);
        var refreshToken = GenerateRefreshToken();
        var refreshTokenHash = HashRefreshToken(refreshToken);
        var refreshTokenExpiresAtUtc = DateTimeOffset.UtcNow.AddDays(_jwtOptions.RefreshTokenExpireDays);

        if (tokenToRevoke is not null)
        {
            tokenToRevoke.RevokedAtUtc = DateTimeOffset.UtcNow;
            tokenToRevoke.ReplacedByTokenHash = refreshTokenHash;
        }

        _dbContext.UserRefreshTokens.Add(new UserRefreshToken
        {
            Id = Guid.NewGuid(),
            UserId = user.Id,
            TokenHash = refreshTokenHash,
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

    private string BuildAccessToken(Repository.Entity.User user)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new("UserId", user.Id.ToString()),
            new(JwtRegisteredClaimNames.Email, user.Email),
            new("Name", user.Name),
            // ClaimTypes.Role la claim duy nhat ma [Authorize(Roles = "...")] doc.
            new(ClaimTypes.Role, user.Role.ToString()),
            // Phan biet access token voi refresh token, tranh dung lan.
            new(TokenTypeClaim, AccessTokenType),
            // Id duy nhat cua token - dung khi can thu hoi (blacklist) luc logout.
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        // KHONG them ClaimTypes.Expired: JwtBearer khong doc claim nay.
        // Han thuc su nam o claim "exp", do JwtService set qua tham so expires.
        return _jwtService.GenerateAccessToken(claims);
    }

    private static string GenerateRefreshToken()
        => Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

    private static string HashRefreshToken(string refreshToken)
        => Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(refreshToken)));
}