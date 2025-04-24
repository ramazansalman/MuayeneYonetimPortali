using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Appointments.Pages;

[PageAuthorize(typeof(AppointmentsRow))]
public class AppointmentsPage : Controller
{
    [Route("Appointments/Appointments")]
    public ActionResult Index()
    {
        return this.GridPage<AppointmentsRow>("@/Appointments/Appointments/AppointmentsPage");
    }
}