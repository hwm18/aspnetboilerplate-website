using System.Web.Mvc;
using Abp.Modules.Cms.Application.Cms.Contents;
using Abp.Modules.Cms.Application.Cms.Contents.Dtos;

namespace AbpWebSite.Web.Controllers
{
    public class PagesController : Controller
    {
        private readonly IContentAppService _contentService;
        public PagesController(IContentAppService contentService)
        {
            _contentService = contentService;
        }

        public ActionResult Index(string pageName)
        {
            var result = _contentService.GetContent(new GetContentInput(pageName));
            return View(result.Content);
        }
    }
}