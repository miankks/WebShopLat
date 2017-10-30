using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverSite1.Models.Pages
{
    [SiteContentType(
        GroupName = Global.GroupNames.Products)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-product.png")]
    [ContentType(DisplayName = "ShoesPage", GUID = "976a0179-0594-445e-bc87-52c790449a63", Description = "")]
    
    public class ShoesPage : SitePageData
    {

        [Ignore]
        public virtual IList<ShoesPage> ShoesItems { get; set; }
        //[Display(
        //    Name = "Shoes Image",
        //    GroupName = SystemTabNames.Content,
        //    Order = 320)]
        //[UIHint(UIHint.Image)]
        //public virtual ContentReference ShoesImage { get; set; }

        //[Display(
        //    Name = "Shoes name",
        //    GroupName = SystemTabNames.Content,
        //    Order = 321)]
        //public virtual string ShoesName { get; set; }

        //[Display(
        //    Name = "Shoes price",
        //    GroupName = SystemTabNames.Content,
        //    Order = 350)]
        //public virtual float ShoesPrice { get; set; }

        //[Display(
        //    Name = "Shoes description",
        //    GroupName = SystemTabNames.Content,
        //    Order = 323)]
        //public virtual XhtmlString ShoesDecscription { get; set; }
    }
}