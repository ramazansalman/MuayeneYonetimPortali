using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MuayeneYonetimPortali.Appointments.AppointmentsRow>;
using MyRow = MuayeneYonetimPortali.Appointments.AppointmentsRow;

namespace MuayeneYonetimPortali.Appointments;

public interface IAppointmentsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AppointmentsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAppointmentsRetrieveHandler
{
    public AppointmentsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}