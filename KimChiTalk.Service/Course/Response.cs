namespace KimChiTalk.Service.Course;

public class Response
{
    public class CourseResponse
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Level { get; set; }
        public int Order { get; set; }
        public bool IsEnrolled { get; set; }
    }
}