namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatagoryColumnToCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Catagory_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Catagory_Id");
            AddForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories");
            DropIndex("dbo.Courses", new[] { "Catagory_Id" });
            DropColumn("dbo.Courses", "Catagory_Id");
        }
    }
}
