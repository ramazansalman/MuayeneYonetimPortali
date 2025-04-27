using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Prescriptions.PrescriptionDrugsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionDrugsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionDrugsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionDrugsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionDrugsSaveHandler
{
    public PrescriptionDrugsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}