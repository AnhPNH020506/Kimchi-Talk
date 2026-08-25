namespace KimChiTalk.Service.Lesson;

public interface IService
{
    public Task<List<Response.GetLessonsResponse>> GetLessons(Guid userId, Guid courseId);
}