using Abp.Cms.Contents;
using Abp.Modules.Cms.Application.Cms.Contents.Dtos;
using AutoMapper;

namespace Abp.Modules.Cms.Application.Cms.Contents
{
    public class ContentAppService : IContentAppService
    {
        private readonly IContentRepository _contentRepository;

        public ContentAppService(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public GetContentOutput GetContent(GetContentInput input)
        {
            var content = _contentRepository.FirstOrDefault(c => c.Url == input.Url);
            if (content == null)
            {
                throw new ContentNotFoundException();
            }

            return new GetContentOutput(Mapper.Map<ContentDto>(content));
        }
    }
}