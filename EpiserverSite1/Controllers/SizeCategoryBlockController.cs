using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpiserverSite1.Models.Blocks;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EpiserverSite1.Controllers
{
    public class SizeCategoryBlockController : BlockController<SizeCategoryBlock>
    {
        public override ActionResult Index(SizeCategoryBlock currentBlock)
        {

            return PartialView(currentBlock);
        }
    }
}
