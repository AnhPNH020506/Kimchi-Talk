using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class UserCourse:BaseEntity<Guid>, IAuditableEntity
{
    public User? User { get; set; }
    public Guid UserId { get; set; }
    public Course? Course { get; set; }
    public Guid CoursesId { get; set; }
    public bool EnrollAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}