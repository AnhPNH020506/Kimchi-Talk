using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.Question;

public class Response
{
    public class GetQuestionResponse
    {
        public Guid Id { get; set; }
        public required string Content { get; set; }
        public QuestionType Type { get; set; }
        public required List<GetAnswerResponse> Answers { get; set; }
    }
    public class GetAnswerResponse
    {
        public Guid Id { get; set; }
        public required string Content { get; set; }
        
    }
    public class SubmitQuestionResponse
    {
       public required List<SubmitQuestionResult> Questions { get; set; }
       public bool IsPassed { get; set; }
        
    }
    public class SubmitQuestionResult
    {
        public Guid QuestionId { get; set; }
        public Guid? GrammarId { get; set; }
        public bool IsCorrect { get; set; }
    }
}