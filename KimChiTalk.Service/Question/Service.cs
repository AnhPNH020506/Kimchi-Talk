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

    public async Task<Response.SubmitQuestionResponse> SubmitQuestions(Request.SubmitQuestionRequest request, Guid userId)
    {
        var questionIds = request.Answers.Select(x => x.QuestionId).ToList();
        var answers = await _context.Answers.Where(a => questionIds.Contains(a.QuestionId)).ToListAsync();
        var answerQuestion = answers.GroupBy(a => a.QuestionId).ToDictionary(g => g.Key, g => g.ToList());
        var grammarsQuestion = await _context.Questions.Where(q => questionIds.Contains(q.Id))
            .ToDictionaryAsync(q => q.Id, q => q.GrammarId);
        var result = new Response.SubmitQuestionResponse
        {
            Questions = new List<Response.SubmitQuestionResult>()
        };
        foreach (var submitted in request.Answers)
        {
            var correctAnswer = answerQuestion[submitted.QuestionId]
                .Where(a => a.IsCorrect)
                .OrderBy(a => a.Order)
                .Select(a => a.Id)
                .ToList();
            var isCorrect = correctAnswer.SequenceEqual(submitted.SelectedAnswerIds);
            result.Questions.Add(new Response.SubmitQuestionResult()
            {
                QuestionId = submitted.QuestionId,
                IsCorrect = isCorrect,
                GrammarId = isCorrect ? null : grammarsQuestion[submitted.QuestionId]

            });


        }
        return result;
    }
}