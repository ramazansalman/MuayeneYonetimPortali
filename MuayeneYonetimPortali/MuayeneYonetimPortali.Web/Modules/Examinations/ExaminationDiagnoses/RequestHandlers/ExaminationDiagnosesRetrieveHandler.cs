using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Examinations.ExaminationDiagnosesRow>;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationDiagnosesRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationDiagnosesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationDiagnosesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationDiagnosesRetrieveHandler
{
    public ExaminationDiagnosesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}