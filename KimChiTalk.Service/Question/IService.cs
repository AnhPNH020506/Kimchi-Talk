using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.Question;

public interface IService
{
    public Task<List<Response.GetQuestionResponse>> GetQuestions(Guid lessonId, QuestionStage questionStage);
    public Task<Response.SubmitQuestionResponse> SubmitQuestions(Request.SubmitQuestionRequest request, Guid userId);
    public Task CreateQuestions(Guid userId, Request.QuestionRequest request);
    public Task DeleteQuestions(Guid userId, Guid questionId);
    public Task UpdateQuestions(Guid userId, Guid questionId, Request.QuestionRequest request);
}