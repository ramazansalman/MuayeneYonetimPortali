using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Administration.TwoFactorCodeRow;

namespace MuayeneYonetimPortali.Administration;

public interface ITwoFactorCodeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class TwoFactorCodeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITwoFactorCodeDeleteHandler
{
    public TwoFactorCodeDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}