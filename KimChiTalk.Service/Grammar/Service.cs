using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Service.Grammar;

public class Service : IService
{
    private readonly AppDbContext _dbContext;
    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Response.GetGrammarResponse>> GetGrammars(Guid userId, Guid lessonId)
    {
        var grammars = await _dbContext.Grammars.Where(g => g.LessonId == lessonId).ToListAsync();
        var userGrammars = await _dbContext.UserGrammars.Where(u => u.UserId == userId).ToListAsync();
        var userGrammarMap = userGrammars.ToDictionary(u => u.GrammarId);
        var result = new List<Response.GetGrammarResponse>();
        foreach (var grammar in grammars)
        {
            userGrammarMap.TryGetValue(grammar.Id, out var userGrammar);
            var isLearned = userGrammar ?.IsLearned ?? false;
            result.Add(new Response.GetGrammarResponse
            {
                Id = grammar.Id,
                Title = grammar.Title,
                Explanation = grammar.Explanation,
                Example = grammar.Example,
                IsLearned = isLearned,
            });
        }
        return result;
    }

    public async Task<Response.GetGrammarResponse?> GetGrammarById(Guid userId, Guid grammarId)
    {
        var grammar = await _dbContext.Grammars.Where(g => g.Id == grammarId).FirstOrDefaultAsync();
        if (grammar == null)
        {
            return null;
        }
        var userGrammar = await _dbContext.UserGrammars.Where(u => u.UserId == userId && u.GrammarId == grammarId).FirstOrDefaultAsync();
        var isLearned = userGrammar ?.IsLearned ?? false;
        var result = new Response.GetGrammarResponse
        {
            Id = grammar.Id,
            Title = grammar.Title,
            Explanation = grammar.Explanation,
            Example = grammar.Example,
            IsLearned = isLearned,

        };
        return result;
    }

    public async Task MarkGrammarAsLearned(Guid userId, Guid grammarId)
    {
        var grammar = await _dbContext.Grammars.Where(g => g.Id == grammarId).FirstOrDefaultAsync();
        if (grammar == null)
        {
            throw new KeyNotFoundException();
        }
        var userGrammar = await _dbContext.UserGrammars.Where(u => u.UserId == userId && u.GrammarId == grammarId).FirstOrDefaultAsync();
        if (userGrammar == null)
        {
            userGrammar = new UserGrammar()
            {
                GrammarId = grammarId,
                UserId = userId,
                IsLearned = true,

            };
            _dbContext.UserGrammars.Add(userGrammar);
        }
        else
        {
            userGrammar.IsLearned = true;
        }
        await _dbContext.SaveChangesAsync();
        
    }

    public async Task CreateGrammar(Guid adminId, Request.GrammarRequest request)
    {
        var grammar = new Repository.Entity.Grammar
        {
            LessonId = request.LessonId,
            Id = Guid.NewGuid(),
            Title = request.Title,
            Explanation = request.Explanation,
            Example = request.Example,
        };
        _dbContext.Grammars.Add(grammar);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteGrammar(Guid userId, Guid grammarId)
    {
       var grammar = _dbContext.Grammars.Where(g => g.Id == grammarId).FirstOrDefaultAsync();
       if (grammar == null)
           {
           throw new KeyNotFoundException();
           }
       _dbContext.Remove(grammar);
       await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateGrammar(Guid userId, Guid grammarId, Request.GrammarRequest request)
    {
        var grammar = await _dbContext.Grammars.Where(g => g.Id == grammarId).FirstOrDefaultAsync();
        if (grammar == null)
        {
            throw new KeyNotFoundException();
        }

        grammar = new Repository.Entity.Grammar
        {
            LessonId = request.LessonId,
            Id = grammarId,
            Title = request.Title,
            Explanation = request.Explanation,
            Example = request.Example,
        };
        _dbContext.Grammars.Update(grammar);
        await _dbContext.SaveChangesAsync();

    }
}