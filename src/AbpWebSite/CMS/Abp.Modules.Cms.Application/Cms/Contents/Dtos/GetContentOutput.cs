using Abp.Application.Services.Dto;

namespace Abp.Modules.Cms.Application.Cms.Contents.Dtos
{
    public class GetContentOutput : IOutputDto
    {
        public ContentDto Content { get; set; }

        public GetContentOutput(ContentDto content)
        {
            Content = content;
        }
    }
}