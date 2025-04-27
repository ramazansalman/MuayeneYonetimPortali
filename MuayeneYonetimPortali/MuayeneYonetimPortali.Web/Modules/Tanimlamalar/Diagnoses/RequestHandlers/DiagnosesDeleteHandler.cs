using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DiagnosesRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDiagnosesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DiagnosesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDiagnosesDeleteHandler
{
    public DiagnosesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}