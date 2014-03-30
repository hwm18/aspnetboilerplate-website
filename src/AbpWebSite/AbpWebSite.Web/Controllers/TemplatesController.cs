using System;
using System.Web.Mvc;
using Abp.Web.Models;
using AbpWebSite.Templates;

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
                var projectCreator = new ProjectCreator(Server.MapPath("~/"));
                var fileBytes = projectCreator.Create("MySpaProject", projectName);
                return File(fileBytes, "application/zip", projectName + ".zip");
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
                var projectCreator = new ProjectCreator(Server.MapPath("~/"));
                var fileBytes = projectCreator.Create("MyMvcProject", projectName);
                return File(fileBytes, "application/zip", projectName + ".zip");
            }
            catch (Exception)
            {
                return View("Error", new AbpErrorInfo("Sorry :(", "Your template could not be created...."));
            }
        }
	}
}