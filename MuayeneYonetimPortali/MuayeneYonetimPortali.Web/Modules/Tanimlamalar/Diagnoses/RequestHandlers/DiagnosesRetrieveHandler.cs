using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.DiagnosesRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DiagnosesRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDiagnosesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DiagnosesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDiagnosesRetrieveHandler
{
    public DiagnosesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}