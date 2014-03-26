using System.Web;
using Abp.Dependency;
using Abp.Localization.Sources.Xml;

namespace AbpWebSite.Web.Localization.AbpWebSite
{
    public class AbpWebSiteLocalizationSource : XmlLocalizationSource
    {
        public AbpWebSiteLocalizationSource()
            : base("AbpWebSite", HttpContext.Current.Server.MapPath("/Localization/AbpWebSite"))
        {
        }
    }
}