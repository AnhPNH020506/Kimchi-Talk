using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class Grammar:BaseEntity<Guid>, IAuditableEntity
{
    public required string Title { get; set; }
    public required string Explanation { get; set; }
    public required string Example { get; set; }
    
    public Guid LessonId { get; set; }
    public Lesson? Lesson { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}