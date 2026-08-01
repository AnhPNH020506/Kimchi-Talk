using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class UserGrammar : BaseEntity<Guid>, IAuditableEntity

{
    public bool IsLearned { get; set; }
    
    public Guid UserId { get; set; }
    public User? User { get; set; }
    
    public Guid GrammarId { get; set; }
    public Grammar? Grammar { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}