using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Examinations.Pages;

[PageAuthorize(typeof(ExaminationsRow))]
public class ExaminationsPage : Controller
{
    [Route("Examinations/Examinations")]
    public ActionResult Index()
    {
        return this.GridPage<ExaminationsRow>("@/Examinations/Examinations/ExaminationsPage");
    }
}