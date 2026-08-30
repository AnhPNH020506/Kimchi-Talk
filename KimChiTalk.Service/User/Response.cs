using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.User;

public class Response
{
    public class CourseProgressResponse
    {
        public Guid CourseId {get; set;}
        public required string CourseTitle {get; set;}
        public required CourseLevel Level {get; set;}
        public required List<LessonProgressResponse> Lessons {get; set;}
    }

    public class LessonProgressResponse
    {
        public Guid LessonId { get; set; }
        public required string Title {get; set;}
        public int Order {get; set;}
        public bool IsCompleted {get; set;}
    }
}