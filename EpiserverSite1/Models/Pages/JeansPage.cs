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
    [ContentType(DisplayName = "JeansPage", GUID = "58df4c04-bd08-4768-8a0e-7ab78fe74c64", Description = "")]
   
    public class JeansPage : SitePageData
    {
        [Display(
            Name = "Jeans Image",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ShoesImage { get; set; }

        [Display(
            Name = "Jeans name",
            GroupName = SystemTabNames.Content,
            Order = 321)]
        public virtual string ShoesName { get; set; }

        [Display(
            Name = "Jeans price",
            GroupName = SystemTabNames.Content,
            Order = 350)]
        public virtual int ShoesPrice { get; set; }

        [Display(
            Name = "Jeans description",
            GroupName = SystemTabNames.Content,
            Order = 323)]
        public virtual XhtmlString ShoesDecscription { get; set; }
    }
}