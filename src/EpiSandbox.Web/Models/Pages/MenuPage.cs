using System.ComponentModel.DataAnnotations;
using EpiSandbox.Web.Models.Blocks;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Menu Page",
        GUID = "34d93a7d-e5a5-4f48-97a6-fae1d01aae35",
        GroupName = "General Content")]
    public class MenuPage : AbstractContentPage
    {
        [Display(
            Name = "Header Block Area", 
            Order = 10)]
        public virtual HeaderBlock HeaderBlock { get; set; }
    }
}