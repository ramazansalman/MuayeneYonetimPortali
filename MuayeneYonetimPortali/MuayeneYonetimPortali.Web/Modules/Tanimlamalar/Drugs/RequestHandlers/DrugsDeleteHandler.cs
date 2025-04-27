using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DrugsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDrugsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DrugsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDrugsDeleteHandler
{
    public DrugsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}