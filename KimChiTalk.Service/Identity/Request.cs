namespace KimChiTalk.Service.Identity;

public class Request
{
    public class LoginRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
    public class RefreshTokenRequest
    {
        public required string RefreshToken { get; set; }
        public required string AccessToken { get; set; }
    }
}