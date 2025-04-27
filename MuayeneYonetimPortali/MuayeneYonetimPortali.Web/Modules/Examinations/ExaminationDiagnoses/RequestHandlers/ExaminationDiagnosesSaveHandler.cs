using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Examinations.ExaminationDiagnosesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationDiagnosesRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationDiagnosesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationDiagnosesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationDiagnosesSaveHandler
{
    public ExaminationDiagnosesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}