using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class UserVocabulary:BaseEntity<Guid>, IAuditableEntity
{
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public Guid VocabularyId { get; set; }
    public Vocabulary? Vocabulary { get; set; }
    
    public bool IsLearned { get; set; }
    public bool IsFavorite { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}