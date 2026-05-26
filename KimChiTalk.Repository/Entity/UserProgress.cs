using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class UserProgress:BaseEntity<Guid>, IAuditableEntity
{
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public Guid LessonId { get; set; }
    public Lesson? Lesson { get; set; }
    public required bool Completed { get; set; }
    public required float Score { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime StartedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastAccessed { get; set; } = DateTime.UtcNow;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}