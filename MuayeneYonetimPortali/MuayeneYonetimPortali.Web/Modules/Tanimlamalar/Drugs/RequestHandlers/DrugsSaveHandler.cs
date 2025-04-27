using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.DrugsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DrugsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDrugsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DrugsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDrugsSaveHandler
{
    public DrugsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}