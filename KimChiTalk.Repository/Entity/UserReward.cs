using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class UserReward : BaseEntity<Guid>, IAuditableEntity
{
    
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public Guid RewardId { get; set; }
    public Reward? Reward { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}