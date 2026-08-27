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
}