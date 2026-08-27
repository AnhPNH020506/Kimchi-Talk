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
}