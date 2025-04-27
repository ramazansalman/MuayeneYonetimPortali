using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Prescriptions.PrescriptionsRow>;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionsRetrieveHandler
{
    public PrescriptionsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}