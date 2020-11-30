namespace TicketSysteemMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categorie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Categorie", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Categorie");
        }
    }
}
