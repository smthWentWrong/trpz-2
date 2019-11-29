namespace WpfApp1.Model.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Login = c.String(),
                    Password = c.String(),
                    Admin = c.Boolean(),
                })
                .PrimaryKey(t => t.Id);
            
        }

        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
