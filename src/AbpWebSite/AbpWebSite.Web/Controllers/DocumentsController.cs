﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbpWebSite.Web.Controllers
{
    public class DocumentsController : AbpWebSiteControllerBase
    {
        //
        // GET: /Documents/
        public ActionResult Index()
        {
            return View();
        }
	}
}