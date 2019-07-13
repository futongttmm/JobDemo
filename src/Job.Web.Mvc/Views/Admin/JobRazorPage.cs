using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Job.Web.Views
{
    public abstract class JobRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected JobRazorPage()
        {
            LocalizationSourceName = JobConsts.LocalizationSourceName;
        }
    }
}
