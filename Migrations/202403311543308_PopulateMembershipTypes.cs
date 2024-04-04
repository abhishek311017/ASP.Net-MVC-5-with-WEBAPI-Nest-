namespace Nest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) values (1,0,0,0)");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) values (2,30,2,10)");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) values (3,90,3,15)");
            Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) values (4,300,4,20)");
        }

        public override void Down()
        {
        }
    }
}
