using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Job.Controllers;

namespace Job.Web.Controllers
{
	[AbpMvcAuthorize]
    [Area("Admin")]
	public class AboutController : JobControllerBase
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
