using Abp.Domain.Entities.Mapping;
using AbpWebSite.Logging;

namespace AbpWebSite.NHibernate.EntityMappings
{
    public class SiteUsageInfoMap : EntityMap<SiteUsageInfo, long>
    {
        public SiteUsageInfoMap()
            : base("AbpWebSiteUsageInfos")
        {
            Map(x => x.Action);
            Map(x => x.Details);
            Map(x => x.ErrorMessage);
            Map(x => x.IsSucceed);
            this.MapCreationTime();
        }
    }
}
