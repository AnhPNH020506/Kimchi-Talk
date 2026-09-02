using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.Question;

public interface IService
{
    public Task<List<Response.GetQuestionResponse>> GetQuestions(Guid lessonId, QuestionStage questionStage);
    public Task<Response.SubmitQuestionResponse> SubmitQuestions(Request.SubmitQuestionRequest request, Guid userId);
    public Task CreateQuestions(Guid adminId, Request.QuestionRequest request);
    public Task DeleteQuestions(Guid adminId, Guid questionId);
    public Task UpdateQuestions(Guid adminId, Guid questionId, Request.QuestionRequest request);
}