using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "About Page",
        GUID = "fd7d0b38-fee6-4f6b-8643-3ae49aa2171b",
        GroupName = "General Content")]
    public class AboutPage : AbstractContentPage
    {
        [Display(Name = "HeadLine", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string HeadLine { get; set; }
        
        [Display(Name = "HeadLine Slug", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual string HeadLineSlug { get; set; }
        
        [Display(Name = "Body", GroupName = SystemTabNames.Content, Order = 30)]
        public virtual XhtmlString Body { get; set; }
    }
}