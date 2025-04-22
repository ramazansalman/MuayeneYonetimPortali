using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.PatientsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.PatientsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IPatientsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PatientsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPatientsListHandler
{
    public PatientsListHandler(IRequestContext context)
            : base(context)
    {
    }
}