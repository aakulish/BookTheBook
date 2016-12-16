namespace BTB_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Books", "Category_ID", c => c.Int());
            CreateIndex("dbo.Books", "Category_ID");
            AddForeignKey("dbo.Books", "Category_ID", "dbo.Categories", "ID");
            DropColumn("dbo.Books", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Category", c => c.String());
            DropForeignKey("dbo.Books", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "Category_ID" });
            DropColumn("dbo.Books", "Category_ID");
            DropTable("dbo.Categories");
        }
    }
}
