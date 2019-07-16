using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Job.Authorization.Roles;
using Job.Authorization.Users;
using Job.MultiTenancy;
using Job.Web.Models;

namespace Job.EntityFrameworkCore
{
    public class JobDbContext : AbpZeroDbContext<Tenant, Role, User, JobDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<JobInfo> JobInfos { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost; Database=JobDb; Trusted_Connection=True;");
        //}
    }
}
