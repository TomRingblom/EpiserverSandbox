using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EpiSandbox.Web.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class ChefPageController : PageController<ChefPage>
    {
        public ActionResult Index(ChefPage currentContent)
        {
            var viewModel = new PageViewModel<ChefPage>(currentContent);
            return View(viewModel);
        }
    }
}