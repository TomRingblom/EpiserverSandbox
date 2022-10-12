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
                },
                new EPiServer.DataAbstraction.TemplateModel()
                {
                    Name = "ChefBlock",
                    Description = "Display chefs on the page",
                    Path = "~/Views/Shared/ChefBlock.cshtml",
                    TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                    AvailableWithoutTag = true
                },
                new EPiServer.DataAbstraction.TemplateModel()
                {
                    Name = "GalleryBlock",
                    Description = "Display images in gallery carousel.",
                    Path = "~/Views/Shared/GalleryBlock.cshtml",
                    TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                    AvailableWithoutTag = true
                });
        }
    }
}