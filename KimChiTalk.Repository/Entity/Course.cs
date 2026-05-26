using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class Course: BaseEntity<Guid>, IAuditableEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    
    public ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
    public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}