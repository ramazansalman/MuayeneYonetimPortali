using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(PatientsRow))]
public class PatientsPage : Controller
{
    [Route("Tanimlamalar/Patients")]
    public ActionResult Index()
    {
        return this.GridPage<PatientsRow>("@/Tanimlamalar/Patients/PatientsPage");
    }
}