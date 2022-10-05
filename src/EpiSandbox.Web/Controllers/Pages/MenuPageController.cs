using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EpiSandbox.Web.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class MenuPageController : PageController<MenuPage>
    {
        public ActionResult Index(MenuPage currentContent)
        {
            var viewModel = new PageViewModel<MenuPage>(currentContent);
            return View(viewModel);
        }
    }
}