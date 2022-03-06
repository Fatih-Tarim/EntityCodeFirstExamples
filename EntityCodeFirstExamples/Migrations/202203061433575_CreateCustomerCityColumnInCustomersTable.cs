namespace EntityCodeFirstExamples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustomerCityColumnInCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "City");
        }
    }
}
