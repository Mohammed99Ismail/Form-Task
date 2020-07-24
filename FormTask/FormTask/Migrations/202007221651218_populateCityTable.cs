namespace FormTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCityTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.Cities (Name,CountryId) values ('Cairo',1),('Giza',1),('Alexandria',1),('New York',2),('Arizona',2),('Florida',2),('Abu Dhabi',3),('Al Ain',3),('Shariqa',3);");
        }

        public override void Down()
        {
        }
    }
}
