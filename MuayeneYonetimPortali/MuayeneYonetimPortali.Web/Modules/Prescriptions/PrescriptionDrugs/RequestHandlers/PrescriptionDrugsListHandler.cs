using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Prescriptions.PrescriptionDrugsRow>;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionDrugsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionDrugsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionDrugsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionDrugsListHandler
{
    public PrescriptionDrugsListHandler(IRequestContext context)
            : base(context)
    {
    }
}