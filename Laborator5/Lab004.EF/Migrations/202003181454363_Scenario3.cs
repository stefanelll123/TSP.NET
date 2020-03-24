namespace Lab004.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Scenario3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BazaDeDate.Photograph",
                c => new
                    {
                        PhotoId = c.Int(nullable: false, identity: true),
                        HighResolutionBits = c.Binary(),
                        Title = c.String(),
                        ThumbnailBits = c.Binary(),
                    })
                .PrimaryKey(t => t.PhotoId);
            
        }
        
        public override void Down()
        {
            DropTable("BazaDeDate.Photograph");
        }
    }
}
