namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddsCustomerBirthdateProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerBirthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerBirthdate");
        }
    }
}
