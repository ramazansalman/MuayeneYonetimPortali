using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.DistrictsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DistrictsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDistrictsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictsRetrieveHandler
{
    public DistrictsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}