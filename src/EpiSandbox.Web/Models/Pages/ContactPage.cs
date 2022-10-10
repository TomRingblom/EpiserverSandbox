using EpiSandbox.Web.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Contact Page",
        GUID = "E4E39880-CDCE-45FF-A896-E4EAF09C4A1D",
        GroupName = "General Content")]
    public class ContactPage : AbstractContentPage
    {
        public virtual ContentArea ContentArea { get; set; }
    }
}