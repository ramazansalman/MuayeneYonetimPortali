using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDepartmentsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentsDeleteHandler
{
    public DepartmentsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}