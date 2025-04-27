using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionDrugsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionDrugsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionDrugsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionDrugsDeleteHandler
{
    public PrescriptionDrugsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}