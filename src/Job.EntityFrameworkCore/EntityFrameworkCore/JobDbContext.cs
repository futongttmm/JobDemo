using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Job.Authorization.Roles;
using Job.Authorization.Users;
using Job.MultiTenancy;

namespace Job.EntityFrameworkCore
{
    public class JobDbContext : AbpZeroDbContext<Tenant, Role, User, JobDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public JobDbContext(DbContextOptions<JobDbContext> options)
            : base(options)
        {
        }
    }
}
