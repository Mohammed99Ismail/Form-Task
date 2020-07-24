namespace FormTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCountryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.Countries (Name) values ('Egypt'),('America'),('United Arab Emirates');");
        }
        
        public override void Down()
        {
        }
    }
}
