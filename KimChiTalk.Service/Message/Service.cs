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
                MessageId = historyMessages.Id,
                UserId = historyMessages.Id,
                IsRead = historyMessages.IsRead,
                CreatedAt = historyMessages.CreatedAt,
                Content = historyMessages.Content,
            });
        return result;


    }

    public async Task<List<Response.MessageResponse>> GetMessageForCustomer(Guid userId)
    {
        var getMessage = await _context.AdminMessages.Where(a => a.UserId == userId).FirstOrDefaultAsync();
        if (getMessage == null)
        {
            throw new Exception("Khong tim thay tai khoan nay");
        }

        var result = new List<Response.MessageResponse>();
        if (result == null) throw new ArgumentNullException(nameof(result));
        result.Add(new Response.MessageResponse()
        {
            MessageId = getMessage.Id,
            Content = getMessage.Content,
            CreatedAt = getMessage.CreatedAt,
            IsRead = getMessage.IsRead,
           
        });
        return result;
    }

    public async Task MarkMessageAsRead(Guid userId, Guid messageId)
    {
       var message = await _context.AdminMessages.Where(a => a.UserId == userId && a.Id == messageId).FirstOrDefaultAsync();
       if (message == null)
           {
            throw new Exception("Khong tim thay tai khoan nay");
           }
       else
       {
           message.IsRead = true;
       }

       await _context.SaveChangesAsync();
    }
}