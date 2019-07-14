using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job.Web.Areas.User.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string PostData { get; set; }
        public string Location { get; set; }


        public JobModel()
        {
            Id = 1; Name = ".Net Developer"; Description = "Developer";
            CompanyName = "ABC"; PostData = "Junior Developer"; Location = "Toronto";
        }
    }
}
