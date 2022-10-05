using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EpiSandbox.Web.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class AboutPageController : PageController<AboutPage>
    {
        public ActionResult Index(AboutPage currentContent)
        {
            var viewModel = new PageViewModel<AboutPage>(currentContent);
            return PartialView(viewModel);
        }
    }
}