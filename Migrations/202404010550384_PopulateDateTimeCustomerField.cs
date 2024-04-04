namespace Nest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDateTimeCustomerField : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers Set DOB='2000-03-07 08:46:28.373' where ID=1");
        }
        
        public override void Down()
        {
        }
    }
}
