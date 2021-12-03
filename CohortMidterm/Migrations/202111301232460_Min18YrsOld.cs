namespace CohortMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Min18YrsOld : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDate");
        }
    }
}
