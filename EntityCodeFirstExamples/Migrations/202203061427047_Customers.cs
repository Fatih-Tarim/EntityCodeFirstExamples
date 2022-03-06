namespace EntityCodeFirstExamples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CostomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerLastName = c.String(),
                    })
                .PrimaryKey(t => t.CostomerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
