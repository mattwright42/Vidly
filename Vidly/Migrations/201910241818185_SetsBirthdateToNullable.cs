namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetsBirthdateToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerBirthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerBirthdate", c => c.DateTime(nullable: false));
        }
    }
}
