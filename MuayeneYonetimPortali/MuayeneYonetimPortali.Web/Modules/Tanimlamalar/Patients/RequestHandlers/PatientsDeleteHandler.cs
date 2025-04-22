using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.PatientsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IPatientsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PatientsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPatientsDeleteHandler
{
    public PatientsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}