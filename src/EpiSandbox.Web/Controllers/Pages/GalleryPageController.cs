using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EpiSandbox.Web.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class GalleryPageController : PageController<GalleryPage>
    {
        public ActionResult Index(GalleryPage currentContent)
        {
            var viewModel = new PageViewModel<GalleryPage>(currentContent);
            return View(viewModel);
        }
    }
}