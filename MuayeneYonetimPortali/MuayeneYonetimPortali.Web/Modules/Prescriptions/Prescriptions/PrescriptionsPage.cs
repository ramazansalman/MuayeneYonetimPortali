using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Prescriptions.Pages;

[PageAuthorize(typeof(PrescriptionsRow))]
public class PrescriptionsPage : Controller
{
    [Route("Prescriptions/Prescriptions")]
    public ActionResult Index()
    {
        return this.GridPage<PrescriptionsRow>("@/Prescriptions/Prescriptions/PrescriptionsPage");
    }
}