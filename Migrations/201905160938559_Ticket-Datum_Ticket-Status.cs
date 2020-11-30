namespace TicketSysteemMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketDatum_TicketStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Datum", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tickets", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Status");
            DropColumn("dbo.Tickets", "Datum");
        }
    }
}
