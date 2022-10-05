using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EpiSandbox.Web.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class HomepageController : PageController<Homepage>
    {
        public ActionResult Index(Homepage currentContent)
        {
            var viewModel = new PageViewModel<Homepage>(currentContent);
            return View(viewModel);
        }
    }
}