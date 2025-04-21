using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(DistrictsRow))]
public class DistrictsPage : Controller
{
    [Route("Tanimlamalar/Districts")]
    public ActionResult Index()
    {
        return this.GridPage<DistrictsRow>("@/Tanimlamalar/Districts/DistrictsPage");
    }
}