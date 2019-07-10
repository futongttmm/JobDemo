using System.Threading.Tasks;
using Job.Configuration.Dto;

namespace Job.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
