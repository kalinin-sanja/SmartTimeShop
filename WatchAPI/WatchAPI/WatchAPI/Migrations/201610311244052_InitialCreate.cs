namespace WatchAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Watches", t => t.Watch_Id)
                .Index(t => t.Watch_Id);
            
            CreateTable(
                "dbo.Watches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Producer = c.String(),
                        Model = c.String(),
                        Rating = c.Double(nullable: false),
                        HasScreen = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS = c.String(),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Colors", "Watch_Id", "dbo.Watches");
            DropIndex("dbo.Colors", new[] { "Watch_Id" });
            DropTable("dbo.Watches");
            DropTable("dbo.Colors");
        }
    }
}
