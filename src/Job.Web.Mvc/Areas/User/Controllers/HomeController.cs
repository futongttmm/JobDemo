using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Job.Web.Areas.User.Models;
using Microsoft.AspNetCore.Mvc;

namespace Job.Web.Mvc.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : AbpController
    {
        public IActionResult Index()
        {
            JobModel job = new JobModel();
            JobDisplayViewModel viewModel = new JobDisplayViewModel() { Job = job };
            return View(viewModel);
        }
    }
}