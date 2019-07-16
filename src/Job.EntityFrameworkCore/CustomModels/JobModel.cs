using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job.Web.Models
{
    public class JobInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string PostData { get; set; }
        public string Location { get; set; }

    }
}
