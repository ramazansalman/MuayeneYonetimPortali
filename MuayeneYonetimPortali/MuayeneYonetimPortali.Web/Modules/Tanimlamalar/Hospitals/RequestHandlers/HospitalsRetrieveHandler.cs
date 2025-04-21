using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.HospitalsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.HospitalsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IHospitalsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class HospitalsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IHospitalsRetrieveHandler
{
    public HospitalsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}