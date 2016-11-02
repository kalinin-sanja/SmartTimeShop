namespace WatchAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WatchShopModel : DbContext
    {
        // Your context has been configured to use a 'WatchShopModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WatchAPI.Controllers.WatchShopModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'WatchShopModel' 
        // connection string in the application configuration file.
        public WatchShopModel()
            : base("name=WatchShopModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<WatchDb> Watches { get; set; }
    }
}