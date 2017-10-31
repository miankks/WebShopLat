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
    //[ContentType(DisplayName = "ShoppingPageViewModel", GUID = "4695e856-0077-438e-ac99-4f84daf02a32",
    //    Description = "")]
    //public class ShoppingPageViewModel : SitePageData

    //{
    //    [Ignore]
    //    public List<ShoppingPage> ShoesPages { get; set; }

    //    //public ShoppingPageViewModel(T currentPage)
    //    //{
    //    //    CurrentPage = currentPage;
    //    //}


    //    //public T CurrentPage { get; }
    //}

    //public static class ShoppingPageViewModel
    //{
    //    /// <summary>
    //    /// Returns a PageViewModel of type <typeparam name="T"/>.
    //    /// </summary>
    //    /// <remarks>
    //    /// Convenience method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
    //    /// </remarks>
    //    public static ShoppingPageViewModel<T> Create<T>(T page) where T : SitePageData
    //    {
    //        return new ShoppingPageViewModel<T>(page);
    //    }
    //}
}