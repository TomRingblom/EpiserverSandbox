using System.ComponentModel.DataAnnotations;
using EpiSandbox.Web.Models.Blocks;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Gallery Page",
        GUID = "78415C19-0A90-43D8-86B3-B1E34F91A7A7",
        GroupName = "General Content")]
    public class GalleryPage : AbstractContentPage
    {
        [Display(
            Name = "Header Block Area", 
            Order = 10)]
        public virtual HeaderBlock HeaderBlock { get; set; }
    }
}