using System.ComponentModel.DataAnnotations;
using EpiSandbox.Web.Models.Blocks;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Event Page",
        GUID = "422E1B51-268C-4224-BF51-EAE473325B01",
        GroupName = "General Content")]
    public class EventPage : AbstractContentPage
    {
        [Display(
            Name = "Header Block Area", 
            Order = 10)]
        public virtual HeaderBlock HeaderBlock { get; set; }
    }
}