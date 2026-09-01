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
        var historyMessages = await _context.AdminMessages.Where(m => m.UserId == userId || userId == null).ToListAsync();
        var result = historyMessages.Select(a => new Response.MessageResponse()
        {
            AdminId = a.AdminId,
            UserId = a.UserId,
            MessageId = a.Id,
            Content = a.Content,
            CreatedAt = a.CreatedAt,
            IsRead = a.IsRead,

        }).ToList();
        return result;


    }

    public async Task<List<Response.MessageResponse>> GetMessageForCustomer(Guid userId)
    {
        var messages = await _context.AdminMessages.Where(a => a.UserId == userId).ToListAsync();

        var result = messages.Select(getMessage => new Response.MessageResponse()
        {   
            MessageId = getMessage.Id,
            AdminId = getMessage.AdminId,
            UserId = getMessage.UserId,
            Content = getMessage.Content,
            CreatedAt = getMessage.CreatedAt,
            IsRead = getMessage.IsRead,
           
        }).ToList();
        return result;
    }

    public async Task<bool> MarkMessageAsRead(Guid userId, Guid messageId)
    {
       var message = await _context.AdminMessages.Where(a => a.UserId == userId && a.Id == messageId).FirstOrDefaultAsync();
       if (message == null)
       {
           return false;
       }
       else
       {
           message.IsRead = true;
       }

       await _context.SaveChangesAsync();
       return true;
    }
}