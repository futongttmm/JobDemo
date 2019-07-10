using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Job.Controllers
{
    public abstract class JobControllerBase: AbpController
    {
        protected JobControllerBase()
        {
            LocalizationSourceName = JobConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
