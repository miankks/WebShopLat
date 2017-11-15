using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EpiserverSite1.Models.Blocks;
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
        private readonly IContentRepository _contentRepository;

        public ShoppingCategoryPageController(IContentRepository contentRepository)
        {
            this._contentRepository = contentRepository;
        }

        public ActionResult Index(ShoppingCategoryPage currentPage)
        {
            #region Only with GetChildren
            //var shoppingRepository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();  //used controller contructor instead (service locator)

            //var shoppingPages = shoppingRepository.GetChildren<ShoppingPage>(currentPage.ContentLink).ToList();
            //var categoryPages = shoppingRepository.GetChildren<ShoppingCategoryPage>(currentPage.ContentLink).ToList();

            //var model = new ShoppingCategoryPageViewModel(currentPage);
            //model.ShoppingCategoryPages = categoryPages;
            //foreach (var link in shoppingLinks)
            //{
            //    var shoppingPage = contentRepository.Get<PageData>(link) as ShoppingPage;

            //    if (shoppingPage != null)
            //    {
            //        model.ShoppingPages.Add(shoppingPage);
            //    }
            //}
            #endregion

            var categoryPages = _contentRepository.GetChildren<ShoppingCategoryPage>(currentPage.ContentLink).ToList();

            var model = new ShoppingCategoryPageViewModel(currentPage)
            {
                ShoppingCategoryPages = categoryPages
            };

            var shoppingLinks = _contentRepository.GetChildren<ShoppingPage>(currentPage.ContentLink).ToList();
            model.ShoppingPages = shoppingLinks;
            TempData["successmessage"] = "Objektet har lagts i korgen!";

            //var sizeCategories = _contentRepository.GetChildren<SizeCategoryBlock>(currentPage.ContentLink).ToList();
            //model.Categorieses = sizeCategories;
            return View(model);
        }


      
        public ActionResult Cart()
        {
            var shop = new ShoppingPage();
          
        
            return View(shop);
            //return RedirectToAction("Index");
            //string name = Request.Form["ProductName"].ToString();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cart([Bind(Include = "ProductName,Id,ProductImage,ProductName,ProductPriceFor")] ShoppingPage model)
        {
            var shop = new ShoppingPage();
            shop.ProductName = model.ProductName;
            if (ModelState.IsValid)
            {
            TempData["successmessage"] = "Objektet har lagts i korgen igen and en till!";
            return View(shop);

            }
            return View(shop);
            //return RedirectToAction("Index");
            //string name = Request.Form["ProductName"].ToString();
        }
    }
}