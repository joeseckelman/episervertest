using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MyAlloySite.Models
{
    [ContentType(DisplayName = "JoeStandardType", GUID = "6f737f84-2797-4a3e-b773-cad56112f150", Description = "")]
    public class JoeStandardType : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "just a heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
        
    }
}