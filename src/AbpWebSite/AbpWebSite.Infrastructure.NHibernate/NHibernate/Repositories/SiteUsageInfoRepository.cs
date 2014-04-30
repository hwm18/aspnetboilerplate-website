using Abp.Domain.Repositories.NHibernate;
using AbpWebSite.Logging;

namespace AbpWebSite.NHibernate.Repositories
{
    public class SiteUsageInfoRepository : NhRepositoryBase<SiteUsageInfo, long>, ISiteUsageInfoRepository
    {

    }
}
