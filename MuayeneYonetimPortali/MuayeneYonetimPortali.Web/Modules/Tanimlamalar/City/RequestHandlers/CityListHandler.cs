using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.CityRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.CityRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface ICityListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CityListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICityListHandler
{
    public CityListHandler(IRequestContext context)
            : base(context)
    {
    }
}