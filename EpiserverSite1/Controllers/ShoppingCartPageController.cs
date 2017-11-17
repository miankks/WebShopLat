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
    public class ShoppingCartPageController : PageControllerBase<ShoppingCartPage>
    {
        private readonly IContentRepository _contentRepository;

        public ShoppingCartPageController(IContentRepository contentRepository)
        {
            this._contentRepository = contentRepository;
        }
        public ActionResult Index(ShoppingCartPage currentPage)
        {
            var categoryPages = _contentRepository.GetChildren<ShoppingCartPage>(currentPage.ContentLink).ToList();

            var model = new ShoppingCartViewModel(currentPage)
            {
              ShoppingCartPages  = categoryPages
            };

            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Index(string productpageid, string productid, string dropdowntipo)
        //{
        //    // var x = GetPage(productpageid)

        //    var categoryPages = _contentRepository.GetChildren<ShoppingCartPage>(currentPage.ContentLink).ToList();

        //    var model = new ShoppingCartViewModel(currentPage)
        //    {
        //        ShoppingCartPages = categoryPages
        //    };

        //    return View(model);
        //}
    }
}