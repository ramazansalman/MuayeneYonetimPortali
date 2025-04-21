using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Tanimlamalar.DepartmentsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDepartmentsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentsRetrieveHandler
{
    public DepartmentsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}