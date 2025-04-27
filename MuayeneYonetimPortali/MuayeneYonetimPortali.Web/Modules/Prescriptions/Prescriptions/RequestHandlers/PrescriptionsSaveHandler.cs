using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Prescriptions.PrescriptionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Prescriptions.PrescriptionsRow;

namespace MuayeneYonetimPortali.Prescriptions;

public interface IPrescriptionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PrescriptionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPrescriptionsSaveHandler
{
    public PrescriptionsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}