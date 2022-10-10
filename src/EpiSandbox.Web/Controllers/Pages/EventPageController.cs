using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EpiSandbox.Web.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class EventPageController : PageController<EventPage>
    {
        public ActionResult Index(EventPage currentContent)
        {
            var viewModel = new PageViewModel<EventPage>(currentContent);
            return View(viewModel);
        }
    }
}