namespace MyBlog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LabelCreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LabelArticles",
                c => new
                    {
                        LabelId = c.Int(nullable: false),
                        ArticleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LabelId, t.ArticleId })
                .ForeignKey("dbo.Labels", t => t.LabelId, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.LabelId)
                .Index(t => t.ArticleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LabelArticles", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.LabelArticles", "LabelId", "dbo.Labels");
            DropIndex("dbo.LabelArticles", new[] { "ArticleId" });
            DropIndex("dbo.LabelArticles", new[] { "LabelId" });
            DropTable("dbo.LabelArticles");
            DropTable("dbo.Labels");
        }
    }
}
