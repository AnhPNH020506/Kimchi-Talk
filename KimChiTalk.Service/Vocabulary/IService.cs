namespace KimChiTalk.Service.Vocabulary;

public interface IService
{
    public Task<List<Response.GetVocabulariesResponse>>GetVocabularies(Guid userId, Guid lessonId);
    public Task<Response.GetVocabulariesResponse?>GetVocabularyById(Guid userId, Guid vocabularyId);

    public Task MarkVocabularyAsLearned(Guid userId, Guid vocabularyId);
    public Task CreateVocabulary(Guid adminId, Request.VocabularyRequest request);
    public Task UpdateVocabulary(Guid adminId, Guid vocabularyId, Request.VocabularyRequest request);
    public Task DeleteVocabulary(Guid adminId, Guid vocabularyId);

}