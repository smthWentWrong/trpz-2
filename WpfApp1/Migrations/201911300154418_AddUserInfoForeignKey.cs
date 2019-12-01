namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserInfoForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.UserInformations", "UserID");
            AddForeignKey("dbo.UserInformations", "UserID", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInformations", "UserID", "dbo.Users");
            DropIndex("dbo.UserInformations", new[] { "UserID" });
        }
    }
}
