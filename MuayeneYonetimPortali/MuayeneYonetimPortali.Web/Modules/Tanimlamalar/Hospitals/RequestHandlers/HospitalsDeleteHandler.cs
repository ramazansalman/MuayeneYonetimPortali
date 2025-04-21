using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalsDeleteHandler
{
    public HospitalsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}