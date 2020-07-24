namespace FormTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Name", c => c.String());
        }
    }
}
