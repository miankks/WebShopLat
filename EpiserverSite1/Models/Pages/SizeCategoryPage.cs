using System;
using System.ComponentModel.DataAnnotations;
using EpiserverSite1.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "SizeCategoryPage", GUID = "b9fa668b-346a-420c-a8a3-42638c3f58c2", Description = "")]
    public class SizeCategoryPage : PageData
    {

        [Display(
            Name = "Sizes",
            Description = "Different sizes to choose from.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual SizeCategoryBlock Sizes { get; set; }
    }
}