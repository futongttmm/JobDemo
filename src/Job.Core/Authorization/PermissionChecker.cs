using Abp.Authorization;
using Job.Authorization.Roles;
using Job.Authorization.Users;

namespace Job.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
