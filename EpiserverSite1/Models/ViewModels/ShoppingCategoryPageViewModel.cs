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
    public class ShoppingCategoryPageViewModel : PageViewModel<SitePageData>
    {
        public ShoppingCategoryPageViewModel(SitePageData currentPage) 
            : base(currentPage)
        {
            this.ShoppingCategoryPages = new List<ShoppingCategoryPage>();
            this.ShoppingPages = new List<ShoppingPage>();
        }

        public List<ShoppingCategoryPage> ShoppingCategoryPages { get; set; }

        public List<ShoppingPage> ShoppingPages { get; set; }
    }
}