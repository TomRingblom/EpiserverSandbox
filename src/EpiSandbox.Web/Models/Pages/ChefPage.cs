using System.ComponentModel.DataAnnotations;
using EpiSandbox.Web.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "Chef Page",
        GUID = "E7E641AE-16BE-4425-A0E3-8FFEEBA3BCA4",
        GroupName = "General Content")]
    public class ChefPage : AbstractContentPage
    {
        [Display(
            Name = "Header Block Area", 
            Order = 10)]
        public virtual HeaderBlock HeaderBlock { get; set; }
        
        [Display(
            Name = "Chefs",
            Order = 20)]
        [AllowedTypes(new []{ typeof(ChefBlock)} )]
        public virtual ContentArea Chefs { get; set; }
    }
}