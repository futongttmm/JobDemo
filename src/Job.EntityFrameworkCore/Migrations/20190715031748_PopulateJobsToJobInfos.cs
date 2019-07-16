using Microsoft.EntityFrameworkCore.Migrations;

namespace Job.Migrations
{
    public partial class PopulateJobsToJobInfos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [dbo].[JobInfos]
           ([Name]
           ,[Description]
           ,[CompanyName]
           ,[PostData]
           ,[Location])
     VALUES
           ('DBA'
           ,'Developer'
           ,'ABC'
           ,'Junior Developer'
           ,'Toronto')");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[JobInfos]
           ([Name]
           ,[Description]
           ,[CompanyName]
           ,[PostData]
           ,[Location])
     VALUES
           ('.Net'
           ,'Developer'
           ,'ABC'
           ,'Junior Developer'
           ,'Edmoton')");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[JobInfos]
           ([Name]
           ,[Description]
           ,[CompanyName]
           ,[PostData]
           ,[Location])
     VALUES
           ('HR assistant'
           ,'Assitant'
           ,'ABC'
           ,'Junior Assistant'
           ,'Toronto')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
