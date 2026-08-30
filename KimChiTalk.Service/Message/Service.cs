namespace KimChiTalk.Service.Message;

public class Service : IService
{
    public Task SendMessageForCustomer(Request.MessageRequest request, Guid adminId)
    {
        throw new NotImplementedException();
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