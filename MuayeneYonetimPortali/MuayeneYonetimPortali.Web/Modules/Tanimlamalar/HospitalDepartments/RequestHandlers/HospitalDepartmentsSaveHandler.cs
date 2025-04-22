using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.HospitalDepartmentsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalDepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalDepartmentsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalDepartmentsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalDepartmentsSaveHandler
{
    public HospitalDepartmentsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}