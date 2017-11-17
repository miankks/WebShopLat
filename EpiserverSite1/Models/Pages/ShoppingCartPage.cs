using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverSite1.Models.Pages
{
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    [SiteContentType(
        GroupName = Global.GroupNames.Products)]
    [ContentType(DisplayName = "ShoppingCartPage", GUID = "334b97f7-29c0-4a6f-be4a-abece1231f53", Description = "")]
    public class ShoppingCartPage : SitePageData
    {
        [Display(
            Name = "Cart Id",
            Description = "Cart Id",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string CartId
        {
            get
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                char[] stringChars = new char[7];
                Random random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                string finalString = new String(stringChars);
                return finalString;
            }
        }

        [Display(
            Name = "Cart Image",
            Description = "Cart Image",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference CartImage { get; set; }

        [Display(
            Name = "Cart total price",
            GroupName = "Price",
            Order = 20)]
        public virtual double TotalCartPrice { get; set; }

        [Display(
            Name = "Cart Moms",
            GroupName = "Price",
            Order = 20)]
        public virtual double CartMoms => TotalCartPrice * 0.25;

        [Display(
            Name = "Cart content area",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        [CultureSpecific]
        public virtual ContentArea CartContentArea { get; set; }
    }
}
