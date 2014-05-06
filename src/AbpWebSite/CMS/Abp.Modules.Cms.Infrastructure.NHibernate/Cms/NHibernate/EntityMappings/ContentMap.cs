using Abp.Cms.Contents;
using Abp.Domain.Entities.Mapping;

namespace Abp.Cms.NHibernate.EntityMappings
{
    public class ContentMap : EntityMap<Content>
    {
        public ContentMap()
            : base("AbpCmsContents")
        {
            References(x => x.Parent).Column("ParentId").Cascade.All();
            Map(x => x.Url);
            Map(x => x.Title);
            Map(x => x.Text);
            this.MapCreationTime();
        }
    }
}
