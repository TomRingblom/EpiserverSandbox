using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class AboutPageController : PageController<AboutPage>
    {
        public ActionResult Index(AboutPage currentContent)
        {
            return View(currentContent);
        }
    }
}