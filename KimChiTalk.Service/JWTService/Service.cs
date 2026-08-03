using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace KimChiTalk.Service.JWTService;

public class Service: IService
{
    private readonly JwtOptions _jwtOptions;
    public Service(JwtOptions jwtOptions)
    {
        _jwtOptions = jwtOptions;
    }
    
    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey));
        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
        var tokeOptions = new JwtSecurityToken(
            issuer: _jwtOptions.Issuer,
            audience: _jwtOptions.Audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(_jwtOptions.ExpireMinutes),
            signingCredentials: signingCredentials
        );
        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
        return tokenString;
    }

    public ClaimsPrincipal? ValidateToken(string token, bool validateLifetime = true)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtOptions.SecretKey);
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidIssuer = _jwtOptions.Issuer,
                ValidateAudience = true,
                ValidAudience = _jwtOptions.Audience,
                ValidateLifetime = validateLifetime,
                ClockSkew = TimeSpan.Zero
            };
            var principle = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
            return principle;
        }
        catch (SecurityTokenException e)
        {
            Console.WriteLine($"Token validation failed: {e.Message}");
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unexpected error during token validation: {e.Message}");
            return null;
        }
    }
    
}