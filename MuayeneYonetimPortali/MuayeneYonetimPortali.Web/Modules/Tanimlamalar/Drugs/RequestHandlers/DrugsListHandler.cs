using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.DrugsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DrugsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDrugsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DrugsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDrugsListHandler
{
    public DrugsListHandler(IRequestContext context)
            : base(context)
    {
    }
}