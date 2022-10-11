using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using static EPiServer.Web.UIHint;

namespace EpiSandbox.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "Chef block",
        GUID = "04127D3A-3EDE-47AC-A0A8-2D27B9287E4B")]
    public class ChefBlock : BlockData
    {
        [Display(
            Name = "Chef Name",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }
        [Display(
            Name = "Chef Title",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Title { get; set; }
        [Display(
            Name = "Chef Info",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString Info { get; set; }
        
        [Display(
            Name = "Chef Image",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual ContentReference Image { get; set; }
    }
}