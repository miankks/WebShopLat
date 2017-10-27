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
    public class ShoesPageController : PageControllerBase<ShoesPage>
    {
        public ActionResult Index(ShoeViewModel currentPage)
        {
            if (currentPage != null)
            {
            var model = new PageViewModel<ShoeViewModel>(currentPage);
            return View(model);
            }

            else
            {
                return Redirect("Index");
            }
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            //var model = new PageViewModel<ShoesPage>();
            //var model = new PageViewModel<ShoeViewModel>(currentPage);
            //List<ShoesPage> model = new List<ShoesPage>();
        }
    }
}