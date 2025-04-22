using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.DoctorsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DoctorsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDoctorsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DoctorsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDoctorsRetrieveHandler
{
    public DoctorsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}