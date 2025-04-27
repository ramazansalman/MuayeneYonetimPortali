using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(DrugsRow))]
public class DrugsPage : Controller
{
    [Route("Tanimlamalar/Drugs")]
    public ActionResult Index()
    {
        return this.GridPage<DrugsRow>("@/Tanimlamalar/Drugs/DrugsPage");
    }
}