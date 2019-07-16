using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Job.EntityFrameworkCore;
using Job.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Job.Web.Mvc.Controllers
{

    public class HomeController : AbpController
    {
        private readonly JobDbContext _jobDbContext;
        public HomeController(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }
       
        public IActionResult Index()
        {
            IEnumerable<JobInfo> jobs = _jobDbContext.JobInfos.ToList();
            
            return View(jobs);
        }
    }
}