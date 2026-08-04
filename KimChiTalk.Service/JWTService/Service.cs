using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace KimChiTalk.Service.JWTService;

public class Service : IService
{
    private readonly JwtOptions _jwtOptions;
    private readonly ILogger<Service> _logger;

    public Service(IOptions<JwtOptions> jwtOptions, ILogger<Service> logger)
    {
        _jwtOptions = jwtOptions.Value;
        _logger = logger;

        // HMAC-SHA256 yeu cau khoa toi thieu 256 bit (32 byte).
        // Ngan hon se nem exception luc tao token -> phat hien som ngay khi khoi dong.
        if (string.IsNullOrWhiteSpace(_jwtOptions.SecretKey) ||
            Encoding.UTF8.GetByteCount(_jwtOptions.SecretKey) < 32)
        {
            throw new InvalidOperationException(
                "JwtOptions.SecretKey phai dai toi thieu 32 ky tu (256 bit).");
        }
    }

    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _jwtOptions.Issuer,
            audience: _jwtOptions.Audience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            // PHAI la UtcNow. DateTime.Now (UTC+7) se lam token song them 7 tieng
            // vi JwtSecurityToken luon quy doi gia tri nay sang Unix timestamp theo UTC.
            expires: DateTime.UtcNow.AddMinutes(_jwtOptions.ExpireMinutes),
            signingCredentials: signingCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    /// <summary>
    /// Tra ve ClaimsPrincipal neu token hop le, null neu token sai/gia mao.
    /// Rieng token HET HAN se nem SecurityTokenExpiredException de tang tren
    /// phan biet duoc "can refresh" voi "token khong hop le".
    /// </summary>
    public ClaimsPrincipal? ValidateToken(string token, bool validateLifetime = true)
    {
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)),
            ValidateIssuer = true,
            ValidIssuer = _jwtOptions.Issuer,
            ValidateAudience = true,
            ValidAudience = _jwtOptions.Audience,
            ValidateLifetime = validateLifetime,
            ClockSkew = TimeSpan.Zero
        };

        try
        {
            return new JwtSecurityTokenHandler()
                .ValidateToken(token, validationParameters, out _);
        }
        catch (SecurityTokenExpiredException)
        {
            // Het han la truong hop "binh thuong" -> nem len de goi luong refresh.
            throw;
        }
        catch (SecurityTokenException ex)
        {
            _logger.LogWarning(ex, "Token khong hop le");
            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Loi khong mong doi khi validate token");
            return null;
        }
    }
}