using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.DoctorsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DoctorsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDoctorsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DoctorsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDoctorsSaveHandler
{
    public DoctorsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}