using MyRow = MuayeneYonetimPortali.Administration.LanguageRow;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;


namespace MuayeneYonetimPortali.Administration;

public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}