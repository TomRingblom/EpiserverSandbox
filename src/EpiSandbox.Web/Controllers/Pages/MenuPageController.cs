using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class MenuPageController : PageController<MenuPage>
    {
        public ActionResult Index(MenuPage currentContent)
        {
            return View(currentContent);
        }
    }
}