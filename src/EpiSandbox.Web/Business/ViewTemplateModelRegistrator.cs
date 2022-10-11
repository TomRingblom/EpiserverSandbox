using EpiSandbox.Web.Models.Blocks;
using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace EpiSandbox.Web.Business
{
    [ServiceConfiguration]
    public class ViewTemplateModelRegistrator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(HeaderBlock),
                new EPiServer.DataAbstraction.TemplateModel()
                {
                    Name = "HeaderBlockTop",
                    Description = "Display a header on top of the page.",
                    Path = "~/Views/Shared/HeaderBlock.cshtml",
                    TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                    AvailableWithoutTag = true
                });
        }
    }
}