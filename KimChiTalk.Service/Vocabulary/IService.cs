namespace KimChiTalk.Service.Vocabulary;

public interface IService
{
    public Task<List<Response.GetVocabulariesResponse>>GetVocabularies(Guid userId, Guid lessonId);

    public Task MarkVocabularyAsLearned(Guid userId, Guid vocabularyId);
    
}