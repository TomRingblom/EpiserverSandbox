using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class HomepageController : PageController<Homepage>
    {
        public ActionResult Index(Homepage currentContent)
        {
            return View(currentContent);
        }
    }
}