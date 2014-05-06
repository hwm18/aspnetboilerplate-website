using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Abp.Modules.Cms.Application.Cms.Contents.Dtos
{
    public class GetContentInput : IInputDto
    {
        [Required]
        public string Url { get; set; }

        public GetContentInput()
        {
            
        }

        public GetContentInput(string url)
        {
            Url = url;
        }
    }
}