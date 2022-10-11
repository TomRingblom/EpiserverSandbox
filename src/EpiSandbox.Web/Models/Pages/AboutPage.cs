using System.ComponentModel.DataAnnotations;
using EpiSandbox.Web.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Pages
{
    [ContentType(
        DisplayName = "About Page",
        GUID = "fd7d0b38-fee6-4f6b-8643-3ae49aa2171b",
        GroupName = "General Content")]
    public class AboutPage : AbstractContentPage
    {
        [Display(
            Name = "Header Block Area", 
            Order = 10)]
        public virtual HeaderBlock HeaderBlock { get; set; }
    }
}