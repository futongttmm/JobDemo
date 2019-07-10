using System.Threading.Tasks;
using Abp.Application.Services;
using Job.Authorization.Accounts.Dto;

namespace Job.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
