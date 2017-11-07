using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverSite1.Models.Pages
{
    [SiteContentType(
        GroupName = Global.GroupNames.Products)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    [ContentType(DisplayName = "ShoppingCategoryPage", GUID = "1b1a4fb4-8099-48ed-b0f2-57815f01b5e3", Description = "")]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ShoppingPage), typeof(ShoppingCategoryPage) })]
    public class ShoppingCategoryPage : SitePageData
    {
        [Display(
            Name = "Main Product Image",
            Description = "Product Image",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference MainProductImage { get; set; }
    }
}