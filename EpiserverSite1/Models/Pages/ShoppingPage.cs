﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
            Name = "Product Id",
            Description = "Product Id",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Id { get; set; }

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
        public virtual double ProductPriceFor { get; set; }

        [Display(
            Name = "Product Moms",
            GroupName = "Price",
            Order = 20)]
        public virtual double Moms => ProductPriceFor * 0.25;

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

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] stringChars = new char[7];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            string finalString = new String(stringChars);
            this.Id = finalString;
        }
    }
}