namespace KimChiTalk.Service.Grammar;

public interface IService
{
    public Task<List<Response.GetGrammarResponse>>GetGrammars(Guid userId, Guid lessonId);
    
}