using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.CityRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.CityRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface ICityRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CityRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICityRetrieveHandler
{
    public CityRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}