using System.Threading.Tasks;
using Abp.Application.Services;
using Job.Sessions.Dto;

namespace Job.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
