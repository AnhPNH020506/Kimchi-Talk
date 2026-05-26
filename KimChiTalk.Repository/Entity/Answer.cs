using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class Answer:BaseEntity<Guid>, IAuditableEntity
{
    public required string Content { get; set; }
    public bool IsCorrect { get; set; }
    
    public Guid QuestionId { get; set; }
    public Question? Question { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}