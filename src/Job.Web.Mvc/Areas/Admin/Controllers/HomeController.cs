using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Job.Controllers;
using Abp.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Job.Web.Controllers
{
	[Area("Admin")]
	[AbpMvcAuthorize]
	public class HomeController : JobControllerBase
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
