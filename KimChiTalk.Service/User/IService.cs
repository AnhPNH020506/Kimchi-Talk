namespace KimChiTalk.Service.User;

public interface IService
{
    public Task<List<Response.CourseProgressResponse>> CourseProgress(Guid userId);
}