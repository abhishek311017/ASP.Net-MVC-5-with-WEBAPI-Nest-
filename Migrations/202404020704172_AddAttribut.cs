namespace Nest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttribut : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
