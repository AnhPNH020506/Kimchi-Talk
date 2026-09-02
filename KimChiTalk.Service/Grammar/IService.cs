namespace KimChiTalk.Service.Grammar;

public interface IService
{
    public Task<List<Response.GetGrammarResponse>>GetGrammars(Guid userId, Guid lessonId);
    public Task<Response.GetGrammarResponse?> GetGrammarById(Guid userId, Guid grammarId);
    public Task MarkGrammarAsLearned(Guid userId, Guid grammarId);
    public Task CreateGrammar(Guid adminId, Request.GrammarRequest request);
    public Task DeleteGrammar(Guid adminId, Guid grammarId);
    public Task UpdateGrammar(Guid adminId, Guid grammarId, Request.GrammarRequest request);
}