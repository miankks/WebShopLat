using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EpiserverSite1.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite1.Models.ViewModels
{
    [ContentType(DisplayName = "ShoppingViewPage", GUID = "44ca6928-2860-4468-af8b-3fa2a32e2089", Description = "")]
    public class ShoppingViewPage : SitePageData
    {
        [Ignore]
        public List<ShoppingPage> ShoesPages { get; set; }
    }
}