using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Abp.Cms.Contents
{
    public class Content : Entity, IHasCreationTime
    {
        public virtual Content Parent { get; set; }

        public virtual string Url { get; set; }

        public virtual string Title { get; set; }

        public virtual string Text { get; set; }

        public virtual DateTime CreationTime { get; set; }
    }
}
