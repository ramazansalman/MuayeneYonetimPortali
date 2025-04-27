using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Examinations.ExaminationsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationsRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationsSaveHandler
{
    public ExaminationsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}