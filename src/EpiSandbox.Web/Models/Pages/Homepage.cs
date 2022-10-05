using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Homepage", 
        Description = "The root page", 
        GUID = "94d37c70-5d9b-4a51-8c35-40b99d827a7f",
        GroupName = "Specialized Content")]
    public class Homepage : AbstractContentPage
    {
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; }
        
        [Display(Name = "Title Body", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual XhtmlString TitleBody { get; set; }
    }
}