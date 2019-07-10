using Abp.AspNetCore.Mvc.ViewComponents;

namespace Job.Web.Views
{
    public abstract class JobViewComponent : AbpViewComponent
    {
        protected JobViewComponent()
        {
            LocalizationSourceName = JobConsts.LocalizationSourceName;
        }
    }
}
