using KimChiTalk.Repository.Entity;

namespace KimChiTalk.Service.Question;

public class Request
{
    public class SubmitQuestionRequest
    {
        public Guid LessonId { get; set; }
        public QuestionStage QuestionStage { get; set; }
        public required List<AnswerSubmission> Answers { get; set; }
    }
    public class AnswerSubmission
    {
        public Guid QuestionId { get; set; }
        public required List<Guid> SelectedAnswerIds { get; set; }
    }
    public class QuestionRequest
    {
        public Guid LessonId { get; set; }
        public Guid? GrammarId { get; set; }
        public QuestionStage QuestionStage { get; set; }
        public required string Content { get; set; }
        public QuestionType QuestionType { get; set; }
        public ICollection<Repository.Entity.Answer> SelectAnswer { get; set; }
        
    }
    public class AnswerRequest
    {
        public Guid QuestionId { get; set; }
        public QuestionStage QuestionStage { get; set; }
        public required string Content { get; set; }
        public int? Order { get; set; }
    }
}