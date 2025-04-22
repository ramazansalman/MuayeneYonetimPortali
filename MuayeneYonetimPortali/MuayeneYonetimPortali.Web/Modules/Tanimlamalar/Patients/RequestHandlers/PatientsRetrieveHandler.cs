using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.PatientsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.PatientsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IPatientsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PatientsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPatientsRetrieveHandler
{
    public PatientsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}