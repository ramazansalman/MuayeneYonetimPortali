using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Administration.TwoFactorCodeRow>;
using MyRow = MuayeneYonetimPortali.Administration.TwoFactorCodeRow;

namespace MuayeneYonetimPortali.Administration;

public interface ITwoFactorCodeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class TwoFactorCodeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITwoFactorCodeRetrieveHandler
{
    public TwoFactorCodeRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}