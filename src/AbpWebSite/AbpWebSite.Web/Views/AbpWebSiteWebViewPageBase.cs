using Abp.Web.Mvc.Views;

namespace AbpWebSite.Web.Views
{
    public abstract class AbpWebSiteWebViewPageBase : AbpWebSiteWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpWebSiteWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpWebSiteWebViewPageBase()
        {
            LocalizationSourceName = "AbpWebSite";
        }
    }
}