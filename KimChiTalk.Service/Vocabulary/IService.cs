namespace KimChiTalk.Service.Vocabulary;

public interface IService
{
    public Task<List<Response.GetVocabulariesResponse>>GetVocabularies(Guid userId, Guid lessonId);
    public Task<Response.GetVocabulariesResponse?>GetVocabularyById(Guid userId, Guid vocabularyId);

    public Task MarkVocabularyAsLearned(Guid userId, Guid vocabularyId);
    
}