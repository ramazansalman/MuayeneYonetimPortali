using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MuayeneYonetimPortali.Tanimlamalar.Pages;

[PageAuthorize(typeof(DepartmentsRow))]
public class DepartmentsPage : Controller
{
    [Route("Tanimlamalar/Departments")]
    public ActionResult Index()
    {
        return this.GridPage<DepartmentsRow>("@/Tanimlamalar/Departments/DepartmentsPage");
    }
}