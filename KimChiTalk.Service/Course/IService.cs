namespace KimChiTalk.Service.Course;

public interface IService
{
    public Task<List<Response.CourseResponse>>  GetCourses(Guid? userId);
    public Task<string> Enroll(Guid userId, Guid courseId);
}