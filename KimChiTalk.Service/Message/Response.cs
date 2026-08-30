namespace KimChiTalk.Service.Message;

public class Response
{
    public class MessageResponse
    {
        public Guid MessageId { get; set; }
        public Guid AdminId { get; set; }
        public Guid UserId { get; set; }
        public bool IsRead { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public required string Content { get; set; }
    }
}