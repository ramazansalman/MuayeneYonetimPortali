using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(DoctorsRow))]
public class DoctorsPage : Controller
{
    [Route("Tanimlamalar/Doctors")]
    public ActionResult Index()
    {
        return this.GridPage<DoctorsRow>("@/Tanimlamalar/Doctors/DoctorsPage");
    }
}