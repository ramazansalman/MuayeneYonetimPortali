using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.DrugsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DrugsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDrugsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DrugsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDrugsRetrieveHandler
{
    public DrugsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}