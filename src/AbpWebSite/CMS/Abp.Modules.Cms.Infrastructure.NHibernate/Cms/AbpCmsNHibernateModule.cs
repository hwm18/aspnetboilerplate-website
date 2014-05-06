using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;
using Abp.Startup.Infrastructure.NHibernate;

namespace Abp.Cms
{
    public class AbpCmsNHibernateModule : AbpModule
    {
        public override void PreInitialize(IAbpInitializationContext initializationContext)
        {
            base.PreInitialize(initializationContext);

            initializationContext.GetModule<AbpNHibernateModule>()
                .Configuration
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()));
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}