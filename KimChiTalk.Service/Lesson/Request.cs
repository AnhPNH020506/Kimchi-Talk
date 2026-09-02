namespace KimChiTalk.Service.Lesson;

public class Request
{
    public class LessonRequest
    {
        public Guid CourseId { get; set; }
        public required string Title { get; set; }
        public int Order { get; set; }
        

    }
    
}