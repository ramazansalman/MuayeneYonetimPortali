using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Administration.Pages;

[PageAuthorize(typeof(TwoFactorCodeRow))]
public class TwoFactorCodePage : Controller
{
    [Route("Administration/TwoFactorCode")]
    public ActionResult Index()
    {
        return this.GridPage<TwoFactorCodeRow>("@/Administration/TwoFactorCode/TwoFactorCodePage");
    }
}