namespace BTB_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        Author = c.String(),
                        Style = c.String(),
                        Category = c.String(),
                        DateOfRelease = c.DateTime(nullable: false),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        LinkToCover = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InStock = c.Int(nullable: false),
                        Expected = c.Int(nullable: false),
                        Book_ID = c.Int(),
                        Shop_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Books", t => t.Book_ID)
                .ForeignKey("dbo.Shops", t => t.Shop_ID)
                .Index(t => t.Book_ID)
                .Index(t => t.Shop_ID);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShopName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journals", "Shop_ID", "dbo.Shops");
            DropForeignKey("dbo.Journals", "Book_ID", "dbo.Books");
            DropIndex("dbo.Journals", new[] { "Shop_ID" });
            DropIndex("dbo.Journals", new[] { "Book_ID" });
            DropTable("dbo.Shops");
            DropTable("dbo.Journals");
            DropTable("dbo.Books");
        }
    }
}
