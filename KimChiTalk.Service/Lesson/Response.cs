namespace KimChiTalk.Service.Lesson;

public class Response
{
    public Guid LessonId { get; set; }
    public required string Title { get; set; }
    public bool IsEnrolled { get; set; }
    
    
}