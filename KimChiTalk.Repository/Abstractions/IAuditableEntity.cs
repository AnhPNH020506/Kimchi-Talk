namespace KimChiTalk.Repository.Abstractions;

public interface IAuditableEntity
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}