namespace KimChiTalk.Service.Vocabulary;

public class Response
{
    public class GetVocabulariesResponse
    {
        public Guid Id { get; set; }
        public required string Word { get; set; }
        public required string Level { get; set; }
        public required string Type { get; set; }
        public required string MeaningVietnamese { get; set; }
        public bool IsLearned { get; set; }
        public bool IsFavorite { get; set; }
    }
    
}