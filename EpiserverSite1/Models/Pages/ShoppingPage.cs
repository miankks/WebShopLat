﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Sgml;

namespace EpiserverSite1.Models.Pages
{
    [SiteContentType(
        GroupName = Global.GroupNames.Products)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    [ContentType(DisplayName = "ShoppingPage", GUID = "df60805a-94cd-4aaf-8541-85438d50ec13", Description = "Main shopping page")]
    [AvailableContentTypes(
        Availability = Availability.Specific,
        Include = new[] { typeof(JeansPage), typeof(ShoesPage), typeof(JacketsPage)}, // Pages we can create under the start page...
        IncludeOn = new [] {typeof(StartPage)})]
    public class ShoppingPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Categories { get; set; }

    }
}