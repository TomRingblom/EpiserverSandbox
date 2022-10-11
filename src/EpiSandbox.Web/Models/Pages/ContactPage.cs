using System.ComponentModel.DataAnnotations;
using EpiSandbox.Web.Models.Blocks;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Contact Page",
        GUID = "E4E39880-CDCE-45FF-A896-E4EAF09C4A1D",
        GroupName = "General Content")]
    public class ContactPage : AbstractContentPage
    {
        [Display(
            Name = "Header Block Area", 
            Order = 10)]
        public virtual HeaderBlock HeaderBlock { get; set; }
    }
}