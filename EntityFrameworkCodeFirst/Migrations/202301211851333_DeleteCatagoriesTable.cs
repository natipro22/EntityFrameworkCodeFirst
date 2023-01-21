namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCatagoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo._Catagories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO _Catagories (Name) SELECT Name FROM dbo.Catagories");
            DropTable("dbo.Catagories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Catagories (Name) SELECT Name FROM dbo._Catagories");
            DropTable("dbo._Catagories");
            
        }
    }
}
