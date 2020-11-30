namespace TicketSysteemMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationUser_ChangePassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ChangePassword", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ChangePassword");
        }
    }
}
