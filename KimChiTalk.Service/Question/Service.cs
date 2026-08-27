using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Service.Question;

public class Service: IService
{
    private readonly AppDbContext _context;
    public Service(AppDbContext context)
    {
        _context = context;
    }
    public async Task<List<Response.GetQuestionResponse>> GetQuestions(Guid lessonId, QuestionStage questionStage)
    {
        var questions = await _context.Questions.Where(q => q.LessonId == lessonId && q.QuestionStage == questionStage)
            .Include(q => q.Answers).ToListAsync();
        var result = new List<Response.GetQuestionResponse>();
        foreach (var question in questions)
        {
            var answerResponse = question.Answers.Select(a => new Response.GetAnswerResponse()
            {
                Id = a.Id,
                Content = a.Content,
            }).ToList();
            result.Add(new Response.GetQuestionResponse()
            {
                Id = question.Id,
                Content = question.Content,
                Answers = answerResponse,
                Type = question.QuestionType
                
            });
        }
        return result;

    }
}