namespace KimChiTalk.Service.Lesson;

public class Service: IService
{
    public Task<List<Response.GetLessonsResponse>> GetLessons(Guid userId, Guid courseId)
    {
        throw new NotImplementedException();
    }
}