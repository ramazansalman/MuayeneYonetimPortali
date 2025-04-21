using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Tanimlamalar.DepartmentsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Tanimlamalar.DepartmentsRow;

namespace MuayeneYonetimPortali.Tanimlamalar;

public interface IDepartmentsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentsSaveHandler
{
    public DepartmentsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}