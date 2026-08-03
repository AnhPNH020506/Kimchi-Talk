namespace KimChiTalk.Service.Identity;

public class Response
{
    public class IdentityResponse
    {
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
        public DateTimeOffset RefreshTokenExpiresAtUtc { get; set; }
    }
}