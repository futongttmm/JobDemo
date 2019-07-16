using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job.Web.Models
{
    public class JobDisplayViewModel
    {
        public IEnumerable<JobInfo> Jobs { get; set; }
    }
}
