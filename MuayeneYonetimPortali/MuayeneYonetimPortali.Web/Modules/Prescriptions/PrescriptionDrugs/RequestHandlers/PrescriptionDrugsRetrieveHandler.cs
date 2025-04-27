using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Prescriptions.PrescriptionDrugsRow>;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionDrugsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionDrugsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionDrugsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionDrugsRetrieveHandler
{
    public PrescriptionDrugsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}