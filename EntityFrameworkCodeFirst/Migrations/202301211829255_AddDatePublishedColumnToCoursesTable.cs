namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatePublishedColumnToCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            DropIndex("dbo.Courses", new[] { "Catagory_Id" });
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "AuthorId");
            RenameColumn(table: "dbo.Courses", name: "Catagory_Id", newName: "CatagoryId");
            AddColumn("dbo.Courses", "DatePublished", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "CatagoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "CatagoryId");
            CreateIndex("dbo.Courses", "AuthorId");
            AddForeignKey("dbo.Courses", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "CatagoryId", "dbo.Catagories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CatagoryId", "dbo.Catagories");
            DropForeignKey("dbo.Courses", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "AuthorId" });
            DropIndex("dbo.Courses", new[] { "CatagoryId" });
            AlterColumn("dbo.Courses", "CatagoryId", c => c.Int());
            AlterColumn("dbo.Courses", "AuthorId", c => c.Int());
            DropColumn("dbo.Courses", "DatePublished");
            RenameColumn(table: "dbo.Courses", name: "CatagoryId", newName: "Catagory_Id");
            RenameColumn(table: "dbo.Courses", name: "AuthorId", newName: "Author_Id");
            CreateIndex("dbo.Courses", "Catagory_Id");
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Catagory_Id", "dbo.Catagories", "Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
