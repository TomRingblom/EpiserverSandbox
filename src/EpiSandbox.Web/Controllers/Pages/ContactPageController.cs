using System.Web.Mvc;
using EpiSandbox.Web.Models.Pages;
using EpiSandbox.Web.Models.ViewModels;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Controllers.Pages
{
    public class ContactPageController : PageController<ContactPage>
    {
        public ActionResult Index(ContactPage currentContent)
        {
            var viewModel = new PageViewModel<ContactPage>(currentContent);
            return View(viewModel);
        }
    }
}