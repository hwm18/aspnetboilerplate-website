using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;

namespace AbpWebSite
{
    public class AbpWebSiteApplicationModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpWebSiteCoreModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
