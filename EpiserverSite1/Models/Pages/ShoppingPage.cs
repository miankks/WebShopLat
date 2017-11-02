using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverSite1.Models.Pages
{
    [ContentType(DisplayName = "ShoppingPage", GUID = "396d282a-900d-41cb-9001-7fee1cbfa896", Description = "")]
    public class ShoppingPage : SitePageData
    {
        [Display(
            Name = "Product Image",
            Description = "Product Image",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ProductImage { get; set; }

        [Display(
            Name = "Product name",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string ProductName { get; set; }

        [Display(
            Name = "Product price",
            GroupName = "Price",
            Order = 20)]
        [CultureSpecific]
        public virtual double ProductPriceFor { get; set; }

        [Display(
            Name = "Product Moms",
            GroupName = "Price",
            Order = 20)]
        [CultureSpecific]
        public virtual double Moms { get; set; }

        [Display(
            Name = "Product description",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual XhtmlString ProductDecscription { get; set; }

        [Display(
            Name = "Product content area",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        [CultureSpecific]
        public virtual ContentArea ProductContentArea { get; set; }
    }
}