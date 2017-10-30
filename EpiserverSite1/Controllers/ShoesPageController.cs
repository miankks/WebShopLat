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
        public ActionResult Index(ShoesPage currentPage)
        {
            //var shoesRepository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();
            //currentPage.ShoesItems = shoesRepository.GetChildren<ShoesPage>(currentPage.ContentLink).ToList();
            //var model = new PageViewModel<ShoesPage>(currentPage);
            //return View(model);

            var model = new PageViewModel<ShoesPage>(currentPage);

            model.CurrentPage = currentPage;
            
            return View(model);

            //    List<ShoeViewModel<ShoesPage>> model = new List<ShoeViewModel<ShoesPage>>(currentPage);
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            //var model = new PageViewModel<ShoesPage>();
            //var model = new PageViewModel<ShoeViewModel>(currentPage);
            //return View(currentPage);
        }
    }
}