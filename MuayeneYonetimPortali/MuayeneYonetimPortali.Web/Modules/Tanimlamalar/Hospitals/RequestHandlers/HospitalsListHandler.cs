using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.HospitalsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalsListHandler
{
    public HospitalsListHandler(IRequestContext context)
            : base(context)
    {
    }
}