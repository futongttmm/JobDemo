using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Job.Configuration;
using Job.Web;

namespace Job.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class JobDbContextFactory : IDesignTimeDbContextFactory<JobDbContext>
    {
        public JobDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<JobDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            JobDbContextConfigurer.Configure(builder, configuration.GetConnectionString(JobConsts.ConnectionStringName));

            return new JobDbContext(builder.Options);
        }
    }
}
