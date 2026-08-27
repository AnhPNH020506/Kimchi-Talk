using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.Question;

public interface IService
{
    public Task<List<Response.GetQuestionResponse>> GetQuestions(Guid lessonId, QuestionStage questionStage);
}