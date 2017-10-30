using System;
using EPiServer.Core;
using EpiserverSite1.Models.Pages;
using EPiServer;
using EPiServer.ServiceLocation;

namespace EpiserverSite1.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; set; }
        public LayoutModel Layout { get; set; }
        public IContent Section { get; set; }
    }

    public static class PageViewModel
    {
        /// <summary>
        /// Returns a PageViewModel of type <typeparam name="T"/>.
        /// </summary>
        /// <remarks>
        /// Convenience method for creating PageViewModels without having to specify the type as methods can use type inference while constructors cannot.
        /// </remarks>
        public static PageViewModel<T> Create<T>(T page) where T : SitePageData
        {
            return new PageViewModel<T>(page);
        }
    }

    public class SitePageBaseViewModelBuilder<TViewModel, TPageType>
        where TViewModel : PageViewModel<ShoesPage>, new()
        where TPageType : SitePageData
    {

        //private readonly TPageType currentPage;

        //private readonly TViewModel vm;

        //private IContentLoader contentLoader;

        //public SitePageBaseViewModelBuilder(TPageType currentPage)
        //{
        //    this.currentPage = currentPage;
        //    this.contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
        //    this.vm = new TViewModel();

        //}
        //public TViewModel Build()
        //{
        //    return this.vm;
        //}

        public IContent Section { get; set; }

        public SitePageData CurrentPage { get; set; }

    }
}
