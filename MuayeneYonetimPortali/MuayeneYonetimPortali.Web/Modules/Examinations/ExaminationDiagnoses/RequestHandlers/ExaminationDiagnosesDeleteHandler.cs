using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationDiagnosesRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationDiagnosesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationDiagnosesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationDiagnosesDeleteHandler
{
    public ExaminationDiagnosesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}