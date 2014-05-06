using System;
using System.Reflection;
using Abp.Cms;
using Abp.Dependency;
using Abp.Startup;

namespace Abp.Modules.Cms.Application.Cms
{
    public class AbpCmsApplicationModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpCmsCoreModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            DtoMappings.Map();
        }
    }
}
