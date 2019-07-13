using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Job.Web.Mvc.Controllers
{
    [AbpAllowAnonymous]
    public class JobController : AbpController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}