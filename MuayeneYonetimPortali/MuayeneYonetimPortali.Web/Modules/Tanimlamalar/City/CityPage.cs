using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(CityRow))]
public class CityPage : Controller
{
    [Route("Tanimlamalar/City")]
    public ActionResult Index()
    {
        return this.GridPage<CityRow>("@/Tanimlamalar/City/CityPage");
    }
}