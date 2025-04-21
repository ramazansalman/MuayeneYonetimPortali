using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(HospitalsRow))]
public class HospitalsPage : Controller
{
    [Route("Tanimlamalar/Hospitals")]
    public ActionResult Index()
    {
        return this.GridPage<HospitalsRow>("@/Tanimlamalar/Hospitals/HospitalsPage");
    }
}