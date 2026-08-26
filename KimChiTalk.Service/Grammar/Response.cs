namespace KimChiTalk.Service.Grammar;

public class Response
{
    public class GetGrammarResponse
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public  required string Explanation { get; set; }
        public required string Example { get; set; }
        public bool IsLearned { get; set; }
    }
}