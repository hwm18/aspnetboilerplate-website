using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace AbpWebSite.Logging
{
    public class SiteUsageInfo : Entity<long>, IHasCreationTime
    {
        public virtual string Action { get; set; }

        public virtual string Details { get; set; }

        public virtual bool IsSucceed { get; set; }

        public virtual string ErrorMessage { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public SiteUsageInfo()
        {
            CreationTime = DateTime.Now;
            IsSucceed = true;
        }

        public SiteUsageInfo(string action)
            : this()
        {
            Action = action;
        }

        public SiteUsageInfo(string action, string details)
            : this(action)
        {
            Details = details;
        }

        public SiteUsageInfo(string action, string details, string errorMessage)
            : this(action, details)
        {
            ErrorMessage = errorMessage;
            IsSucceed = false;
        }
    }
}
