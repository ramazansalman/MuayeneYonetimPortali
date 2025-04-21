using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DistrictsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDistrictsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictsDeleteHandler
{
    public DistrictsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}