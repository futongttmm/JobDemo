﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Job.Controllers;

namespace Job.Web.Controllers
{
	[AbpMvcAuthorize]
	public class HomeController : JobControllerBase
	{
		public ActionResult Index()
		{
			// return View("~/Views/Admin/Home/Index.cshtml");
			return View();
		}
	}
}