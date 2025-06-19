using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Administration.TwoFactorCodeRow>;
using MyRow = MuayeneYonetimPortali.Administration.TwoFactorCodeRow;

namespace MuayeneYonetimPortali.Administration;

public interface ITwoFactorCodeListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class TwoFactorCodeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITwoFactorCodeListHandler
{
    public TwoFactorCodeListHandler(IRequestContext context)
            : base(context)
    {
    }
}