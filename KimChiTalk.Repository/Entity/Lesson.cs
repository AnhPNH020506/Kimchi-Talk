using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class Lesson:BaseEntity<Guid>, IAuditableEntity
{
    public required string Title { get; set; }
    public Course? Courses { get; set; }
    public Guid CourseId { get; set; }
    
    public ICollection<Vocabulary> Vocabulary { get; set; } = new List<Vocabulary>();
    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public ICollection<Grammar>  Grammars { get; set; } = new List<Grammar>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}