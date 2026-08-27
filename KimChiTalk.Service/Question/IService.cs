using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.Question;

public interface IService
{
    public Task<List<Response.GetQuestionResponse>> GetQuestions(Guid lessonId, QuestionStage questionStage);
    public Task<Response.SubmitQuestionResponse> SubmitQuestions(Request.SubmitQuestionRequest request, Guid userId);
}