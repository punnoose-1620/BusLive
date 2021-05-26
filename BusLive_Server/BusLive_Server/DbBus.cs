namespace BusLive_Server
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbBus : DbContext
    {
        // Your context has been configured to use a 'DbBus' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BusLive_Server.DbBus' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbBus' 
        // connection string in the application configuration file.
        public DbBus()
            : base("name=DbBus")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<BusData> BusData { get; set; }
    }

    public class BusData
    {
        public int Id { get; set; }
        public int RouteNumber { get; set; }
        public string BusRegNumber { get; set; }
        public string Towards { get; set; }
        public string DriverName { get; set; }
        public string DriverContactNumber { get; set; }
        public string InchargeName { get; set; }
        public string InchargeNumber { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public double speed { get; set; }
        public DateTime timestamp { get; set; }
    }
}