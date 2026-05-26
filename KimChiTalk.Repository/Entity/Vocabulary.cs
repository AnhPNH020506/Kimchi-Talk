using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class Vocabulary:BaseEntity<Guid>, IAuditableEntity
{
    public required string Word { get; set; }
    public required string Level { get; set; }
    public required string Type { get; set; }
    public required string  MeaningVietNamese { get; set; }
    
    public Guid LessonId { get; set; }
    public Lesson? Lesson { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}