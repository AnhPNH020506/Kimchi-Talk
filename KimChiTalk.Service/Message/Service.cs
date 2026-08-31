using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Service.Message;

public class Service : IService
{
    private readonly AppDbContext _context;
    public Service(AppDbContext context)
    {
        _context = context;
    }
    public async Task SendMessageForCustomer(Request.MessageRequest request, Guid adminId)
    {
        var adminMessage = new AdminMessage
        {
            AdminId = adminId,
            UserId = request.UserId,
            IsRead = false,
            Content = request.Content
        };
        _context.AdminMessages.Add(adminMessage);
        await _context.SaveChangesAsync();

    }

    public async Task<List<Response.MessageResponse>> GetHistoryMessages(Guid? userId)
    {
        var historyMessages = await _context.AdminMessages.Where(m => m.UserId == userId || userId == null).FirstOrDefaultAsync();
        var result = new List<Response.MessageResponse>();
        if (historyMessages != null)
            result.Add(new Response.MessageResponse()
            {
                UserId = historyMessages.Id,
                Content = historyMessages.Content,
            });
        return result;


    }

    public Task<List<Response.MessageResponse>> GetMessageForCustomer(Guid userId)
    {
        throw new NotImplementedException();
    }
}