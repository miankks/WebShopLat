using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "FAQItem", GUID = "698ea89b-7b56-4ca6-ba4d-d641a325b53a", Description = "",
        AvailableInEditMode = false)]
    public class FAQItem : SitePageData
    {

        [Display(
            Name = "FAQs",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Question { get; set; }

        [Display(
            Name = "FAQs",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString Answer { get; set; }

    }
}