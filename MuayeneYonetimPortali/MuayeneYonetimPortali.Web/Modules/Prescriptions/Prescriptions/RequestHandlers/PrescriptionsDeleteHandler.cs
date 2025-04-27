using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionsDeleteHandler
{
    public PrescriptionsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}