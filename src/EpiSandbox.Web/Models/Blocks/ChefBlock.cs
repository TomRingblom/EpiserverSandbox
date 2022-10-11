using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "Chef block",
        GUID = "04127D3A-3EDE-47AC-A0A8-2D27B9287E4B")]
    public class ChefBlock : BlockData
    {
        [Display(
            Name = "Chef Name",
            Order = 10)]
        public virtual string Name { get; set; }
        [Display(
            Name = "Chef Title",
            Order = 20)]
        public virtual string Title { get; set; }
        [Display(
            Name = "Chef Info",
            Order = 30)]
        public virtual XhtmlString Info { get; set; }
    }
}