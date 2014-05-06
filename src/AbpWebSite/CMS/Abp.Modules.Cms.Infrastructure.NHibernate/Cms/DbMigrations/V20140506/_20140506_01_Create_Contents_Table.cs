using Abp.Data.Migrations.FluentMigrator;
using FluentMigrator;

namespace Abp.Cms.DbMigrations.V20140506
{
    [Migration(2014050601)]
    public class _20140506_01_Create_Contents_Table : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("AbpCmsContents")
                .WithIdAsInt32()
                .WithColumn("ParentId").AsInt32().ForeignKey("AbpCmsContents", "Id").Nullable()
                .WithColumn("Url").AsString(128).NotNullable()
                .WithColumn("Title").AsString(256).NotNullable()
                .WithColumn("Text").AsString().NotNullable()
                .WithCreationTimeColumn();
        }
    }
}
