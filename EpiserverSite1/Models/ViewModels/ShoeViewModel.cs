using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EpiserverSite1.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer;
using EPiServer.ServiceLocation;

namespace EpiserverSite1.Models.ViewModels
{
    public class ShoeViewModel<T> :SitePageData
    {
        public ShoeViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        //public virtual List<ShoesPage> ShoesPages { get; set; }

        public T CurrentPage { get; }
    }
}