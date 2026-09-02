namespace KimChiTalk.Service.Course;

public interface IService
{
    public Task<List<Response.CourseResponse>>  GetCourses(Guid? userId);
    public Task<string> Enroll(Guid userId, Guid courseId);
    public Task CreateCourse(Guid adminId, Request.CourseRequest request);
    public Task UpdateCourse(Guid adminId, Guid courseId, Request.CourseRequest request);
    public Task DeleteCourse(Guid adminId, Guid courseId);
    
}