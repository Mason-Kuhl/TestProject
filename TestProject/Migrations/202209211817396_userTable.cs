namespace TestProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userTable : DbMigration
    {
        public override void Up()
        {
            // Admins
            Sql("INSERT INTO Users (FirstName, LastName, Password, Username, Email, AdminId, Discriminator)" +
                "VALUES" +
                    "('Deb', 'Wilber', 'admin', 'Antim1952', 'deb.wilber@eps.org', 39402, 'Admin')");

            // Teachers
            Sql("INSERT INTO Users (FirstName, LastName, Password, Username, Email, DisplayName, TeacherId, Discriminator)" +
                "VALUES" +
                    "('Lora', 'McGee', 'password', 'Whoper', 'sharon.perez@eps.org', 'Mrs. McGee', 61565, 'Teacher')");

            // Students
            Sql("INSERT INTO Users (FirstName, LastName, Password, Username, Email, DisplayName, StudentId, CurrentTier, Discriminator)" +
                "VALUES" +
                    "('Martha', 'Bechtol', 'our21', 'Storid', 'martha.bechtol@class.eps.org', 'Storid', 30901, 1, 'Student')");

            // Parents
            Sql("INSERT INTO Users (FirstName, LastName, Password, Username, Email, GuardianId, Discriminator)" +
                "VALUES" +
                    "('Curtis', 'Bechtol', 'bai0Choe', 'Whyall', 'curtisjbechtol@teleworm.us', 11590, 'Guardian')");
        }
        
        public override void Down()
        {

        }
    }
}
