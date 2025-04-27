using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Examinations.ExaminationsRow>;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationsRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationsListHandler
{
    public ExaminationsListHandler(IRequestContext context)
            : base(context)
    {
    }
}