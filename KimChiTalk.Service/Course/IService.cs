namespace KimChiTalk.Service.Course;

public interface IService
{
    public Task<List<Response.CourseResponse>>  GetCourses(Guid? userId);
    public Task<string> Enroll(Guid userId, Guid courseId);
    public Task CreateCourse(Guid userId, Request.CourseRequest request);
    public Task UpdateCourse(Guid userId, Guid courseId, Request.CourseRequest request);
    public Task DeleteCourse(Guid userId, Guid courseId);
    
}