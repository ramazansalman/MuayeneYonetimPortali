using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Tanimlamalar.DepartmentsRow>;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDepartmentsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentsListHandler
{
    public DepartmentsListHandler(IRequestContext context)
            : base(context)
    {
    }
}