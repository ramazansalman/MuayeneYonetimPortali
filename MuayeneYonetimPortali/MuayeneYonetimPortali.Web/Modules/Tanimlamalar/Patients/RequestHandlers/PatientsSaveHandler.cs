using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.PatientsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.PatientsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IPatientsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PatientsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPatientsSaveHandler
{
    public PatientsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}