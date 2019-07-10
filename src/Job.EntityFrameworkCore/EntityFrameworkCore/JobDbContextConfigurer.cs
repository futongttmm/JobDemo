using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Job.EntityFrameworkCore
{
    public static class JobDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<JobDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<JobDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
