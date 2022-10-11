using System.ComponentModel.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiSandbox.Web.Models.Blocks
{
    [ContentType(
        DisplayName = "Header Block",
        GUID = "444D3DF5-0F29-4702-9F01-CC1DD3775DD1")]
    public class HeaderBlock : SiteBlockData
    {
        [Display(
            Name = "Title",
            Description = "Add a title",
            GroupName = SystemTabNames.Content, 
            Order = 10)]
        public virtual string Title { get; set; }
        
        [Display(
            Name = "Text in black",
            Description = "Add the text you want in black",
            GroupName = SystemTabNames.Content, 
            Order = 20)]
        public virtual string TextBlackFirst { get; set; }
        
        [Display(
            Name = "Text in red",
            Description = "Add the text you want in red",
            GroupName = SystemTabNames.Content, 
            Order = 30)]
        public virtual string TextRed { get; set; }
        
        [Display(
            Name = "Text in black after red",
            Description = "Add the text you want in black after the red text",
            GroupName = SystemTabNames.Content, 
            Order = 40)]
        public virtual string TextBlackSecond { get; set; }
    }
}