using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Job.MultiTenancy.Dto;

namespace Job.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

