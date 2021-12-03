namespace CohortMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationTest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "BirthDate", c => c.DateTime());
        }
    }
}
