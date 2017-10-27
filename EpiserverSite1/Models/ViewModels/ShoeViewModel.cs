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
    public class ShoeViewModel<T> : IShoeViewModel<T> where T : ShoesPage
    {
        public ShoeViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public List<ShoesPage> ShoesPages { get; set; }

        public T CurrentPage { get; }
    }

    public static class ShoeViewModel
    {
        /// <summary>
        /// Returns a ShoePageViewModel of type <typeparam name="T"/>.
        /// </summary>
        /// <remarks>
        /// Convenience method for creating ShoePageViewModels without having to specify the type as methods can use type inference while constructors cannot.
        /// </remarks>
        public static PageViewModel<T> Create<T>(T page) where T : SitePageData
        {
            return new PageViewModel<T>(page);
        }
    }
}