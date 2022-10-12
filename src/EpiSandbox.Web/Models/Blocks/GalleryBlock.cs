using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "Gallery Block",
        GUID = "7C740518-22A4-4CCF-9CB6-A153FFE70A73",
        Description = "Add pictures to your gallery")]
    public class GalleryBlock : BlockData
    {
        [Display(
            Name = "Gallery Image",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentReference Image { get; set; }
    }
}