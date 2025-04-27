using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.DiagnosesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DiagnosesRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDiagnosesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DiagnosesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDiagnosesSaveHandler
{
    public DiagnosesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}