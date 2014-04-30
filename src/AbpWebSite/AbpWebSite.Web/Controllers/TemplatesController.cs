using System;
using System.Web.Mvc;
using Abp.Web.Models;
using AbpWebSite.Logging;
using AbpWebSite.Templates;

namespace AbpWebSite.Web.Controllers
{
    public class TemplatesController : AbpWebSiteControllerBase
    {
        private readonly ISiteUsageInfoRepository _siteUsageInfoRepository;

        public TemplatesController(ISiteUsageInfoRepository siteUsageInfoRepository)
        {
            _siteUsageInfoRepository = siteUsageInfoRepository;
        }

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
                WriteInfo("Templates.CreateSpaProject", projectName);
                return File(fileBytes, "application/zip", projectName + ".zip");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
                WriteError("Templates.CreateMpaProject", projectName, ex);
                return View("Error", new AbpErrorInfo("Sorry :(", "Your template could not be created...."));
            }
        }

        public ActionResult CreateMpaProject(string projectName)
        {
            try
            {
                var projectCreator = new ProjectCreator(Server.MapPath("~/"));
                var fileBytes = projectCreator.Create("MyMvcProject", projectName);
                WriteInfo("Templates.CreateMpaProject", projectName);
                return File(fileBytes, "application/zip", projectName + ".zip");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
                WriteError("Templates.CreateMpaProject", projectName, ex);
                return View("Error", new AbpErrorInfo("Sorry :(", "Your template could not be created...."));
            }
        }

        private void WriteInfo(string action, string details)
        {
            try
            {
                _siteUsageInfoRepository.Insert(new SiteUsageInfo(action, details));
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
        }

        private void WriteError(string action, string details, Exception ex)
        {
            try
            {
                _siteUsageInfoRepository.Insert(new SiteUsageInfo(action, details, ex.Message));
            }
            catch (Exception ex2)
            {
                Logger.Error(ex2.Message, ex2);
            }
        }
    }
}