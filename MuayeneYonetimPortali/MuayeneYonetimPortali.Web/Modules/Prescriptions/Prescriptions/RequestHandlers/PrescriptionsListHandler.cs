using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Prescriptions.PrescriptionsRow>;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionsListHandler
{
    public PrescriptionsListHandler(IRequestContext context)
            : base(context)
    {
    }
}