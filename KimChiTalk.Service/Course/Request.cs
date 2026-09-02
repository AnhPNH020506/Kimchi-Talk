using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.Course;

public class Request
{
    public class CourseRequest
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required CourseLevel Level { get; set; }
        public int Order { get; set; }
    }
}