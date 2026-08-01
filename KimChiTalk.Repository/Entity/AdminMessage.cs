using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class AdminMessage : BaseEntity<Guid>, IAuditableEntity
{
    public Guid AdminId { get; set; }
    public User? Admin { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public required string Content { get; set; }
    public bool IsRead { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}