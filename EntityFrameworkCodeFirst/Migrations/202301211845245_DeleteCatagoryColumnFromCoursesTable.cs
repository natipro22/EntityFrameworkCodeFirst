namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCatagoryColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "CatagoryId", "dbo.Catagories");
            DropIndex("dbo.Courses", new[] { "CatagoryId" });
            DropColumn("dbo.Courses", "CatagoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CatagoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "CatagoryId");
            AddForeignKey("dbo.Courses", "CatagoryId", "dbo.Catagories", "Id", cascadeDelete: true);
        }
    }
}
