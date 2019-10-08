using System.Web.Mvc;
using MyAlloySite.Models.Pages;
using EPiServer.Web.Mvc;

namespace MyAlloySite.Com.Controllers.Pages
{
    public class EndPageController : PageController<EndPage>
    {
        public ActionResult Index(EndPage currentPage)
        {
            return View("Index", currentPage);
        }
    }
}