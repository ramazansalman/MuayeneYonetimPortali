using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.HospitalDepartmentsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalDepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalDepartmentsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalDepartmentsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalDepartmentsRetrieveHandler
{
    public HospitalDepartmentsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}