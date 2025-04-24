using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MuayeneYonetimPortali.Appointments.AppointmentsRow;

namespace MuayeneYonetimPortali.Appointments;

public interface IAppointmentsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AppointmentsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAppointmentsDeleteHandler
{
    public AppointmentsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}