﻿using System;
using System.Web;
using System.Web.Mvc;

namespace EpiserverSite1
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }

        //public override string GetVaryByPublicString(HttpContext context, string custom)
        //{
        //    return context.Request.Url.AbsoluteUri;
        //}
    }
}