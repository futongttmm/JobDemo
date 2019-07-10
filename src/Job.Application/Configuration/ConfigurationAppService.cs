using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Job.Configuration.Dto;

namespace Job.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : JobAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
