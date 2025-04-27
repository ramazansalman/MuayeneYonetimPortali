using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.DiagnosesRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DiagnosesRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDiagnosesListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DiagnosesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDiagnosesListHandler
{
    public DiagnosesListHandler(IRequestContext context)
            : base(context)
    {
    }
}