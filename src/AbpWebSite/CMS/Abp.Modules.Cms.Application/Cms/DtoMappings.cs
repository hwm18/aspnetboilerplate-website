using Abp.Cms.Contents;
using Abp.Modules.Cms.Application.Cms.Contents.Dtos;
using AutoMapper;

namespace Abp.Modules.Cms.Application.Cms
{
    public static class DtoMappings
    {
        public static void Map()
        {
            Mapper.CreateMap<Content, ContentDto>();
        }
    }
}
