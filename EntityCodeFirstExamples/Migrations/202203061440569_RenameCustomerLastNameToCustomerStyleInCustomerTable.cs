namespace EntityCodeFirstExamples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCustomerLastNameToCustomerStyleInCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerStyle", c => c.String());
            DropColumn("dbo.Customers", "CustomerLastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerLastName", c => c.String());
            DropColumn("dbo.Customers", "CustomerStyle");
        }
    }
}
