using FluentMigrator.VersionTableInfo;

namespace Abp.Cms.DbMigrations
{
    [VersionTableMetaData]
    public class VersionTable : DefaultVersionTableMetaData
    {
        public override string TableName
        {
            get
            {
                return "AbpCmsVersionInfo";
            }
        }
    }
}
