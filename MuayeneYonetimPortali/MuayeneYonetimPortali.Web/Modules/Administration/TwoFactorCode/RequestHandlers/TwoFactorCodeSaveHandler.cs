using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Administration.TwoFactorCodeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Administration.TwoFactorCodeRow;

namespace MuayeneYonetimPortali.Administration;

public interface ITwoFactorCodeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class TwoFactorCodeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITwoFactorCodeSaveHandler
{
    public TwoFactorCodeSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}