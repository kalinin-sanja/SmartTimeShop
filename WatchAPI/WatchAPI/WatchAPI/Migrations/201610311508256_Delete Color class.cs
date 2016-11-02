namespace WatchAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColorclass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Colors", "Watch_Id", "dbo.Watches");
            DropIndex("dbo.Colors", new[] { "Watch_Id" });
            AddColumn("dbo.Watches", "Colors", c => c.String());
            DropTable("dbo.Colors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hex = c.String(),
                        Name = c.String(),
                        Watch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Watches", "Colors");
            CreateIndex("dbo.Colors", "Watch_Id");
            AddForeignKey("dbo.Colors", "Watch_Id", "dbo.Watches", "Id");
        }
    }
}
