namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GPA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "GPA", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "GPA");
        }
    }
}
