namespace WatchAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myFirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Watches", "SreenSizes", c => c.String());
            AddColumn("dbo.Watches", "PictureUrls", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Watches", "PictureUrls");
            DropColumn("dbo.Watches", "SreenSizes");
        }
    }
}
