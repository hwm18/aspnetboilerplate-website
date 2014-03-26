using Abp.Web.Mvc.Controllers;

namespace AbpWebSite.Web.Controllers
{
    public abstract class AbpWebSiteControllerBase : AbpController
    {
        protected AbpWebSiteControllerBase()
        {
            LocalizationSourceName = "AbpWebSite";
        }
    }
}