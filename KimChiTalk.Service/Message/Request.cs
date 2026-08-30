namespace KimChiTalk.Service.Message;

public class Request
{
    public class MessageRequest
    {
        public Guid UserId { get; set; }
        public required string Content { get; set; }
    }
}