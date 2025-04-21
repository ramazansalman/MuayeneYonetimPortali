using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.HospitalsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalsSaveHandler
{
    public HospitalsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}