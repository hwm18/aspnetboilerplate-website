using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Cms;
using Abp.Dependency;
using Abp.Localization;
using Abp.Modules;
using Abp.Startup;
using AbpWebSite.Web.Localization.AbpWebSite;

namespace AbpWebSite.Web
{
    public class AbpWebSiteWebModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpWebSiteNHibernateModule),
                       typeof(AbpWebSiteApplicationModule),
                       typeof(AbpWebSiteWebApiModule),
                       typeof(AbpWebSiteApplicationModule),
                       typeof(AbpCmsNHibernateModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            LocalizationHelper.RegisterSource<AbpWebSiteLocalizationSource>();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
