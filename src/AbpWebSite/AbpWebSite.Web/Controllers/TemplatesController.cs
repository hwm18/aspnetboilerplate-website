using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Models;

namespace AbpWebSite.Web.Controllers
{
    public class TemplatesController : AbpWebSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateSpaProject(string projectName)
        {
            try
            {
                var projectCreator = new ProjectCreator();
                var fileBytes = projectCreator.Create("SinglePageApplication", "MySpaProject", projectName);
                return File(fileBytes, "application/x-zip");
            }
            catch (Exception)
            {
                return View("Error", new AbpErrorInfo("Sorry :(", "Your template could not be created...."));
            }
        }

        public ActionResult CreateMpaProject(string projectName)
        {
            try
            {
                var projectCreator = new ProjectCreator();
                var fileBytes = projectCreator.Create("MultiPageApplication", "MyMvcProject", projectName);
                return File(fileBytes, "application/x-zip");
            }
            catch (Exception)
            {
                return View("Error", new AbpErrorInfo("Sorry :(", "Your template could not be created...."));
            }
        }
	}
}