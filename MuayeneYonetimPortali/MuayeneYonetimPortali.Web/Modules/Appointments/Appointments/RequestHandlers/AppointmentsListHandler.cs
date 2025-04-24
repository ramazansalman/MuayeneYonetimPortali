using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MuayeneYonetimPortali.Appointments.AppointmentsRow>;
using MyRow = MuayeneYonetimPortali.Appointments.AppointmentsRow;

namespace MuayeneYonetimPortali.Appointments;

public interface IAppointmentsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AppointmentsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAppointmentsListHandler
{
    public AppointmentsListHandler(IRequestContext context)
            : base(context)
    {
    }
}