namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserInfoKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInformations", "User_Id", "dbo.Users");
            DropIndex("dbo.UserInformations", new[] { "User_Id" });
            RenameColumn(table: "dbo.UserInformations", name: "User_Id", newName: "UserID");
            AlterColumn("dbo.UserInformations", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.UserInformations", "UserID");
            AddForeignKey("dbo.UserInformations", "UserID", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInformations", "UserID", "dbo.Users");
            DropIndex("dbo.UserInformations", new[] { "UserID" });
            AlterColumn("dbo.UserInformations", "UserID", c => c.Int());
            RenameColumn(table: "dbo.UserInformations", name: "UserID", newName: "User_Id");
            CreateIndex("dbo.UserInformations", "User_Id");
            AddForeignKey("dbo.UserInformations", "User_Id", "dbo.Users", "Id");
        }
    }
}
