using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.HospitalDepartmentsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalDepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalDepartmentsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalDepartmentsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalDepartmentsListHandler
{
    public HospitalDepartmentsListHandler(IRequestContext context)
            : base(context)
    {
    }
}