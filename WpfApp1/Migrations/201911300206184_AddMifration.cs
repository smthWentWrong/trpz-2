namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMifration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInformations", "UserID", "dbo.Users");
            DropIndex("dbo.UserInformations", new[] { "UserID" });
            RenameColumn(table: "dbo.UserInformations", name: "UserID", newName: "User_Id");
            AlterColumn("dbo.UserInformations", "User_Id", c => c.Int());
            CreateIndex("dbo.UserInformations", "User_Id");
            AddForeignKey("dbo.UserInformations", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInformations", "User_Id", "dbo.Users");
            DropIndex("dbo.UserInformations", new[] { "User_Id" });
            AlterColumn("dbo.UserInformations", "User_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.UserInformations", name: "User_Id", newName: "UserID");
            CreateIndex("dbo.UserInformations", "UserID");
            AddForeignKey("dbo.UserInformations", "UserID", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
