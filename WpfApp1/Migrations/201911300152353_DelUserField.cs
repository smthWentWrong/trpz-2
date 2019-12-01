namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelUserField : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "userInformation_ID", "dbo.UserInformations");
            DropIndex("dbo.Users", new[] { "userInformation_ID" });
            DropColumn("dbo.Users", "userInformation_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "userInformation_ID", c => c.Int());
            CreateIndex("dbo.Users", "userInformation_ID");
            AddForeignKey("dbo.Users", "userInformation_ID", "dbo.UserInformations", "ID");
        }
    }
}
