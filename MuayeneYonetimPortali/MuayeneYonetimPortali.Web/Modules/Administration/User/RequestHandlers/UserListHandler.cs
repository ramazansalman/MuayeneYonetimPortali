using MyRow = MuayeneYonetimPortali.Administration.UserRow;
using MyRequest = MuayeneYonetimPortali.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Administration.UserRow>;

namespace MuayeneYonetimPortali.Administration;

public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}