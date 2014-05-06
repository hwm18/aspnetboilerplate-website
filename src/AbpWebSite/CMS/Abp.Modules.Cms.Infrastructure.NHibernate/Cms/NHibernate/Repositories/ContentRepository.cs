using Abp.Cms.Contents;
using Abp.Domain.Repositories.NHibernate;

namespace Abp.Cms.NHibernate.Repositories
{
    public class ContentRepository : NhRepositoryBase<Content>, IContentRepository
    {
    }
}
