using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EpiserverSite1.Models.Pages;
using EpiserverSite1.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    public class ShoppingCategoryPageController : PageControllerBase<ShoppingCategoryPage>
    {
        private IContentRepository contentRepository;

        public ShoppingCategoryPageController(IContentRepository contentRepository)
        {
            this.contentRepository = contentRepository;
        }

        public ActionResult Index(ShoppingCategoryPage currentPage)
        {
            #region Only with GetChildren
            //var shoppingRepository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>(); used controller contructor instead (service locator)

            //var shoppingPages = shoppingRepository.GetChildren<ShoppingPage>(currentPage.ContentLink).ToList();
            //var categoryPages = shoppingRepository.GetChildren<ShoppingCategoryPage>(currentPage.ContentLink).ToList();

            //var model = new ShoppingCategoryPageViewModel(currentPage);
            //model.ShoppingCategoryPages = categoryPages;
            #endregion

            var categoryPages = contentRepository.GetChildren<ShoppingCategoryPage>(currentPage.ContentLink).ToList();

            var model = new ShoppingCategoryPageViewModel(currentPage)
            {
                ShoppingCategoryPages = categoryPages
            };

            var shoppingLinks = contentRepository.GetChildren<ShoppingPage>(currentPage.ContentLink).ToList();
            model.ShoppingPages = shoppingLinks;

            //foreach (var link in shoppingLinks)
            //{
            //    var shoppingPage = contentRepository.Get<PageData>(link) as ShoppingPage;

            //    if (shoppingPage != null)
            //    {
            //        model.ShoppingPages.Add(shoppingPage);
            //    }
            //}

            return View(model);
        }
    }
}