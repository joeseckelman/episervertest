using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace MyAlloySite.Models.Pages
{
    [ContentType(
        DisplayName = "End Page",
        GUID = "6671aa96-0a1b-4618-88e3-c98e1a78dcb4",
        Description = "End Page",
        GroupName = "Standard")]
    public class EndPage : PageData
    {
        [Display(
            Name = "Main Content Area",
            Description = "Main Content Area",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}