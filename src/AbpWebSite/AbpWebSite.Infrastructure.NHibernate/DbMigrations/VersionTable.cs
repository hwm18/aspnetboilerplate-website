using FluentMigrator.VersionTableInfo;

namespace AbpWebSite.DbMigrations
{
    [VersionTableMetaData]
    public class VersionTable : DefaultVersionTableMetaData
    {
        public override string TableName
        {
            get
            {
                return "AbpWebVersionInfo";
            }
        }
    }
}
