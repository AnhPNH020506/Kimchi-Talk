using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class User:BaseEntity<Guid>, IAuditableEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string HashshedPassword { get; set; }
    public bool IsActive { get; set; } = true;
    public UserRole Role { get; set; }
    
    public ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
    public ICollection<UserProgress> UserProgresses { get; set; } = new List<UserProgress>();
    public ICollection<UserVocabulary> UserVocabulary { get; set; } = new List<UserVocabulary>();
    public ICollection<UserGrammar> UserGrammars { get; set; } = new List<UserGrammar>();
    public ICollection<UserReward> UserRewards { get; set; } = new List<UserReward>();
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}