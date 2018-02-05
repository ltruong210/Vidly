namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRentalToNewRental : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            AddColumn("dbo.Rentals", "DateReturned", c => c.DateTime());
            DropColumn("dbo.Rentals", "RentalDate");
            DropColumn("dbo.Rentals", "ReturnDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "ReturnDate", c => c.DateTime());
            AddColumn("dbo.Rentals", "RentalDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "DateReturned");
            DropColumn("dbo.Rentals", "DateRented");
        }
    }
}
