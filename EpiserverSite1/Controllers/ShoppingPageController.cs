
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
    public class ShoppingPageController : PageControllerBase<ShoesPage>
    {
        public ActionResult Index(ShoppingPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var model =new  PageViewModel<ShoppingPage>(currentPage);

            return View(model);
        }
    }
}