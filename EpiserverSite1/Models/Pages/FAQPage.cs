using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.Pages
{
    public class FAQPage : SitePageData
    {
        [Ignore]
        public IList<FAQItem> FaqItems { get; set; }
    }
}