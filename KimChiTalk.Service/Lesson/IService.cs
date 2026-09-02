namespace KimChiTalk.Service.Lesson;

public interface IService
{
    public Task<List<Response.GetLessonsResponse>> GetLessons(Guid userId, Guid courseId);
    public Task CreateLesson(Guid adminId, Request.LessonRequest request);
    public Task DeleteLesson(Guid adminId, Guid lessonId);
    public Task UpdateLesson(Guid adminId, Request.LessonRequest request, Guid lessonId);
}