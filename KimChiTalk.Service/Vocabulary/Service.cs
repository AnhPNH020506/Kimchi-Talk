using KimChiTalk.Repository;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Service.Vocabulary;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Response.GetVocabulariesResponse>> GetVocabularies(Guid userId, Guid lessonId)
    {
        var vocabularies = await _dbContext.Vocabulary.Where(v => v.LessonId == lessonId).ToListAsync();
        var userVocabularies  = await _dbContext.UserVocabulary.Where(u => u.UserId == userId).ToListAsync();
        var userVocabMap = userVocabularies.ToDictionary(x => x.VocabularyId);
        var result = new List<Response.GetVocabulariesResponse>();
        foreach (var vocabulary in vocabularies)
        {
            userVocabMap.TryGetValue(vocabulary.Id, out var userVocab);
            var isLearned = userVocab ?.IsLearned ?? false;
            var isFavorite = userVocab ?.IsFavorite ?? false;
            result.Add(new Response.GetVocabulariesResponse
            {
                Id = vocabulary.Id,
                Word = vocabulary.Word ,
                Level = vocabulary.Level,
                Type = vocabulary.Type,
                MeaningVietnamese = vocabulary.MeaningVietNamese,
                IsLearned = isLearned,
                IsFavorite = isFavorite

            });
            
        }
        return result;
    }
}