using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class Question:BaseEntity<Guid>, IAuditableEntity
{
    public required string Content { get; set; }
    public required string Type { get; set; }
    
    public Guid LessonId { get; set; }
    public Lesson? Lesson { get; set; }
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}