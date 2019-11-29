namespace WpfApp1.Model.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Admin", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn( "dbo.Users", "Admin" );
        }
    }
}
