namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCatagoriesTableWithData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Catagories (Name) VALUES ('Web Development')");
            Sql("INSERT INTO Catagories (Name) VALUES ('Programming Languages')");
        }
        
        public override void Down()
        {

        }
    }
}
