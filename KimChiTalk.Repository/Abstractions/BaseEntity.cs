namespace KimChiTalk.Repository.Abstractions;

public class BaseEntity<TKey>
{
    public TKey Id { get; set; } = default!;
    
    public bool IsDeleted { get; set; }
}