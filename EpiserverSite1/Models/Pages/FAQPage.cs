using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "FAQPage", GUID = "6b9101e2-2340-41a5-8abe-9840ba84a84d", Description = "")]
    public class FAQPage : SitePageData
    {
        [Ignore]
        public IList<FAQItem> FaqItems { get; set; }
    }
}