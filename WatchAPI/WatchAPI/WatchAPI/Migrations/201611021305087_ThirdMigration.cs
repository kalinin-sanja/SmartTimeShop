namespace WatchAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Watches", newName: "WatchDbs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.WatchDbs", newName: "Watches");
        }
    }
}
