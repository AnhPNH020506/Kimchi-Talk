using KimChiTalk.Repository.Abstractions;

namespace KimChiTalk.Repository.Entity;

public class Reward : BaseEntity<Guid>, IAuditableEntity
{
    public required string Title { get; set; }
    public required string Message { get; set; }
    public required string ImgUrl { get; set; }
    public CourseLevel Level { get; set; }
    public MilestoneType? MilestoneType { get; set; }
    
    public ICollection<UserReward> UserRewards { get; set; } = new List<UserReward>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}