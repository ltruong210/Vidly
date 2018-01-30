namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "isSubcribed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "isSubcribed", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscribedToNewletter");
        }
    }
}
