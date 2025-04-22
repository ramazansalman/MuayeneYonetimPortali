using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.DoctorsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DoctorsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDoctorsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DoctorsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDoctorsListHandler
{
    public DoctorsListHandler(IRequestContext context)
            : base(context)
    {
    }
}