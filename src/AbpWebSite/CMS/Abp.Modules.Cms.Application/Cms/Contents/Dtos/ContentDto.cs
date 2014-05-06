using System;
using Abp.Application.Services.Dto;

namespace Abp.Modules.Cms.Application.Cms.Contents.Dtos
{
    public class ContentDto : EntityDto
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime CreationTime { get; set; }
    }
}