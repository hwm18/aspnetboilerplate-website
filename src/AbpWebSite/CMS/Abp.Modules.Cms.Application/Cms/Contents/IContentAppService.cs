using Abp.Application.Services;
using Abp.Modules.Cms.Application.Cms.Contents.Dtos;

namespace Abp.Modules.Cms.Application.Cms.Contents
{
    public interface IContentAppService : IApplicationService
    {
        GetContentOutput GetContent(GetContentInput input);
    }
}