using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MuayeneYonetimPortali.Appointments.AppointmentsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MuayeneYonetimPortali.Appointments.AppointmentsRow;

namespace MuayeneYonetimPortali.Appointments;

public interface IAppointmentsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AppointmentsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAppointmentsSaveHandler
{
    public AppointmentsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}