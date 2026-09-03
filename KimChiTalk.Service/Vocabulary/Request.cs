namespace KimChiTalk.Service.Vocabulary;

public class Request
{
    public class VocabularyRequest
    {
        public Guid LessonId { get; set; }
        public required string Word { get; set; }
        public required string Level { get; set; }
        public required string Type { get; set; }
        public required string MeaningVietnamese { get; set; }
    }
    
}