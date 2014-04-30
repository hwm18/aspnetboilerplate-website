using Abp.Data.Migrations.FluentMigrator;
using FluentMigrator;

namespace AbpWebSite.DbMigrations.V20140430
{
    [Migration(2014043001)]
    public class _20140430_01_CreateSiteUsageInfos : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("AbpWebSiteUsageInfos")
                .WithIdAsInt64()
                .WithColumn("Action").AsString(128).NotNullable()
                .WithColumn("Details").AsString(512).Nullable()
                .WithColumn("IsSucceed").AsBoolean().NotNullable().WithDefaultValue(true)
                .WithColumn("ErrorMessage").AsString(512).Nullable()
                .WithCreationTimeColumn();
        }
    }
}
