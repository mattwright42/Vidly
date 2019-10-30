namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevertsToPriorCode : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AgeRanges");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AgeRanges",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
