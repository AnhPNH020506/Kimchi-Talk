using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;
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

    public async Task<Response.GetVocabulariesResponse?> GetVocabularyById(Guid userId, Guid vocabularyId)
    {
       var vocabulary = await _dbContext.Vocabulary.Where(v => v.Id == vocabularyId).FirstOrDefaultAsync();
       if (vocabulary == null)
       {
           return null;
       }
       var userVocabulary = await _dbContext.UserVocabulary.Where(u => u.VocabularyId == vocabularyId && u.UserId == userId).FirstOrDefaultAsync();
       var isLearned = userVocabulary ?.IsLearned ?? false;
       var isFavorite = userVocabulary ?.IsFavorite ?? false;
       var result = new Response.GetVocabulariesResponse
       {
           Id = vocabulary.Id,
           Word = vocabulary.Word,
           Level = vocabulary.Level,
           Type = vocabulary.Type,
           IsLearned = isLearned,
           IsFavorite = isFavorite,
           MeaningVietnamese = vocabulary.MeaningVietNamese
       };
       return result;
    }

    public async Task MarkVocabularyAsLearned(Guid userId, Guid vocabularyId)
    {
        var vocabulary = await _dbContext.Vocabulary.Where(v => v.Id == vocabularyId).FirstOrDefaultAsync();
        if (vocabulary == null)
        {
            throw new KeyNotFoundException();    
        }
        var userVocabulary = await _dbContext.UserVocabulary.Where(u => u.UserId == userId && u.VocabularyId == vocabularyId).FirstOrDefaultAsync();
        if(userVocabulary == null)
        {
            userVocabulary = new UserVocabulary()
            {
                VocabularyId = vocabularyId,
                UserId = userId,
                IsLearned = true,
                IsFavorite = false

            };
             _dbContext.UserVocabulary.Add(userVocabulary);

        }
        else
        {
            userVocabulary.IsLearned = true;
        }
        await _dbContext.SaveChangesAsync();
    }

    public async Task CreateVocabulary(Guid adminId, Request.VocabularyRequest request)
    {
        var vocabulary = new Repository.Entity.Vocabulary
        {
            LessonId =  request.LessonId,
            Id = Guid.NewGuid(),
            Word = request.Word,
            Level = request.Level,
            Type = request.Type,
            MeaningVietNamese = request.MeaningVietnamese,
            
        };
        _dbContext.Vocabulary.Add(vocabulary);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateVocabulary(Guid adminId, Guid vocabularyId, Request.VocabularyRequest request)
    {
       var  vocabulary = _dbContext.Vocabulary.Where(v => v.Id == vocabularyId).FirstOrDefault();
       if (vocabulary == null)
           {
           throw new KeyNotFoundException();
           }

           vocabulary = new Repository.Entity.Vocabulary
           {
               LessonId = request.LessonId,
               Id = vocabularyId,
               Word = request.Word,
               Level = request.Level,
               Type = request.Type,
               MeaningVietNamese = request.MeaningVietnamese,

           };
           _dbContext.Vocabulary.Update(vocabulary);
           await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteVocabulary(Guid adminId, Guid vocabularyId)
    {
        var vocabulary = _dbContext.Vocabulary.Where(v => v.Id == vocabularyId).FirstOrDefault();
        if (vocabulary == null)
            {
            throw new KeyNotFoundException();
            }
        _dbContext.Vocabulary.Remove(vocabulary);
        await _dbContext.SaveChangesAsync();
    }
}