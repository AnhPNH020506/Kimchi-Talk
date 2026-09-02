namespace KimChiTalk.Service.Grammar;

public class Request
{
    public class GrammarRequest
    {
        public Guid LessonId { get; set; }
        public Guid? QuestionId { get; set; }
        public required string Title { get; set; }
        public required string Explanation { get; set; }
        public required string Example { get; set; }
    }
}