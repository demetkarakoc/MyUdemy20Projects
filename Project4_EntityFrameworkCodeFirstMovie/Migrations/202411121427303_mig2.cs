namespace Project4_EntityFrameworkCodeFirstMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CategoryId", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Movies", "Category_CategoryID");
            AddForeignKey("dbo.Movies", "Category_CategoryID", "dbo.Categories", "CategoryID");
            DropColumn("dbo.Movies", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Category", c => c.String());
            DropForeignKey("dbo.Movies", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "Category_CategoryID" });
            DropColumn("dbo.Movies", "Category_CategoryID");
            DropColumn("dbo.Movies", "CategoryId");
        }
    }
}
