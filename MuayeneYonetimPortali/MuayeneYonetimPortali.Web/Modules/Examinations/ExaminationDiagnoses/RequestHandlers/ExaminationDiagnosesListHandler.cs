using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Examinations.ExaminationDiagnosesRow>;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationDiagnosesRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationDiagnosesListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationDiagnosesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationDiagnosesListHandler
{
    public ExaminationDiagnosesListHandler(IRequestContext context)
            : base(context)
    {
    }
}