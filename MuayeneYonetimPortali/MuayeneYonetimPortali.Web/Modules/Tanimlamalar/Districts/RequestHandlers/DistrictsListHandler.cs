using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.DistrictsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DistrictsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDistrictsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictsListHandler
{
    public DistrictsListHandler(IRequestContext context)
            : base(context)
    {
    }
}