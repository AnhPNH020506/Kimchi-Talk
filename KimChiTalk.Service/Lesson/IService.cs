namespace KimChiTalk.Service.Lesson;

public interface IService
{
    public Task<List<Response.GetLessonsResponse>> GetLessons(Guid userId, Guid courseId);
    public Task CreateLesson(Guid userId, Request.LessonRequest request);
    public Task DeleteLesson(Guid userId, Guid lessonId);
    public Task UpdateLesson(Guid userId, Request.LessonRequest request, Guid lessonId);
}