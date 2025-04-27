using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(DiagnosesRow))]
public class DiagnosesPage : Controller
{
    [Route("Tanimlamalar/Diagnoses")]
    public ActionResult Index()
    {
        return this.GridPage<DiagnosesRow>("@/Tanimlamalar/Diagnoses/DiagnosesPage");
    }
}