using EpiSandbox.Web.Models.Pages;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}