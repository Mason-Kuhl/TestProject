namespace TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'1', N'Admin')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'2', N'Teacher')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'3', N'Student')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'4', N'Guardian')
            ");
        }

        public override void Down()
        {
        }
    }
}
