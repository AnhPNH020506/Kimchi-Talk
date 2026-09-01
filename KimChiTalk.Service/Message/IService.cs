namespace KimChiTalk.Service.Message;

public interface IService
{
    public Task SendMessageForCustomer(Request.MessageRequest request, Guid adminId);
    public Task<List<Response.MessageResponse>>GetHistoryMessages(Guid? userId);
    public Task<List<Response.MessageResponse>>GetMessageForCustomer(Guid userId);
    public Task<bool> MarkMessageAsRead(Guid userId, Guid messageId);
}