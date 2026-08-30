using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;

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

    public Task<List<Response.MessageResponse>> GetHistoryMessages(Guid? userId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Response.MessageResponse>> GetMessageForCustomer(Guid userId)
    {
        throw new NotImplementedException();
    }
}