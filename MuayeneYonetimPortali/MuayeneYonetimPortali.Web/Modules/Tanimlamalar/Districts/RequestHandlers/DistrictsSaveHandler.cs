using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.DistrictsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DistrictsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDistrictsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictsSaveHandler
{
    public DistrictsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}