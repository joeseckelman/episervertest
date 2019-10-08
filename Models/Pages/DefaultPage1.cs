using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MyAlloySite.Models.Pages
{
    [ContentType(DisplayName = "standardjoepage", GUID = "586bae20-ae25-49c3-819c-e554b64092e6", Description = "")]
    public class standardjoepage : PageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Heading",
                    Description = "The Page Heading",
                    GroupName = SystemTabNames.Content,
                    Order = 0)]
                public virtual XhtmlString Heading { get; set; }

                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }

    }
}