using MyRow = MuayeneYonetimPortali.Administration.RoleRow;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Administration.RoleRow>;


namespace MuayeneYonetimPortali.Administration;

public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}