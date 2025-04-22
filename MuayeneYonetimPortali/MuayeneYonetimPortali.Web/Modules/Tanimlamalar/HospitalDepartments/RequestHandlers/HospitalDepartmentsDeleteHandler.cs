using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalDepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalDepartmentsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalDepartmentsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalDepartmentsDeleteHandler
{
    public HospitalDepartmentsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}