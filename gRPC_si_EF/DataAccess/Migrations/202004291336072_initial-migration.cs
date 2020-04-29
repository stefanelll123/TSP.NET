namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Guid(nullable: false),
                        Text = c.String(),
                        PostPostId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Posts", t => t.PostPostId, cascadeDelete: true)
                .Index(t => t.PostPostId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Guid(nullable: false),
                        Description = c.String(),
                        Domain = c.String(),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "PostPostId", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "PostPostId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
        }
    }
}
