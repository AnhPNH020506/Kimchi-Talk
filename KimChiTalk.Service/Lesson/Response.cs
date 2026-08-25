namespace KimChiTalk.Service.Lesson;

public class Response
{
    public Guid CourseId { get; set; }
    public required string Title { get; set; }
    public int Order { get; set; }
    public bool IsUnlocked { get; set; }
    public bool IsCompleted { get; set; }
    
    
}