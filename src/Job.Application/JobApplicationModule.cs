using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Job.Authorization;

namespace Job
{
    [DependsOn(
        typeof(JobCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class JobApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<JobAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(JobApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
