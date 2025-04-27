using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationsRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationsDeleteHandler
{
    public ExaminationsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}