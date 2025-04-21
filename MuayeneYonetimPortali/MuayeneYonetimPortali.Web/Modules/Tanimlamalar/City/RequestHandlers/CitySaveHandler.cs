using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.CityRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.CityRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface ICitySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CitySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICitySaveHandler
{
    public CitySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}