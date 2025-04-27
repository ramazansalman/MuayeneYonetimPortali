using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Examinations.ExaminationsRow>;
using MyRow = MuayeneYonetimPortali.Examinations.ExaminationsRow;

namespace MuayeneYonetimPortali.Examinations;

public interface IExaminationsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ExaminationsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExaminationsRetrieveHandler
{
    public ExaminationsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}