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
    [ContentType(DisplayName = "JacketsPage", GUID = "6f280848-cca4-4fde-8060-ded1faae10ee", Description = "")]
   
    public class JacketsPage : SitePageData
    {
        [Display(
            Name = "Jacket Image",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ShoesImage { get; set; }

        [Display(
            Name = "Jacket name",
            GroupName = SystemTabNames.Content,
            Order = 321)]
        public virtual string ShoesName { get; set; }

        [Display(
            Name = "Jacket price",
            GroupName = SystemTabNames.Content,
            Order = 350)]
        public virtual int ShoesPrice { get; set; }

        [Display(
            Name = "Jacket description",
            GroupName = SystemTabNames.Content,
            Order = 323)]
        public virtual XhtmlString ShoesDecscription { get; set; }
    }
}