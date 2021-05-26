namespace BusLive_Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RouteNumber = c.Int(nullable: false),
                        BusRegNumber = c.String(),
                        Towards = c.String(),
                        DriverName = c.String(),
                        DriverContactNumber = c.String(),
                        InchargeName = c.String(),
                        InchargeNumber = c.String(),
                        lat = c.Double(nullable: false),
                        lon = c.Double(nullable: false),
                        speed = c.Double(nullable: false),
                        timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusDatas");
        }
    }
}
