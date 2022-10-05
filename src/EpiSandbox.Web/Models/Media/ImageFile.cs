using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiSandbox.Web.Models.Media
{
    [ContentType(DisplayName = "Image", GUID = "dfd5a7db-11f0-48d6-b3b8-6e71f5538a93")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png")]
    public class ImageFile : ImageData
    {
        [Display(Name = "Alternate Text")]
        public virtual string AltText { get; set; }
    }
}