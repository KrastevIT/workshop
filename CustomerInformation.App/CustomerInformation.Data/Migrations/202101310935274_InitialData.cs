namespace CustomerInformation.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HomeAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.HomePhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        HomeAddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HomeAddresses", t => t.HomeAddressId, cascadeDelete: true)
                .Index(t => t.HomeAddressId);
            
            CreateTable(
                "dbo.OfficeAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.OfficePhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        OfficeAddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OfficeAddresses", t => t.OfficeAddressId, cascadeDelete: true)
                .Index(t => t.OfficeAddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAddresses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OfficePhones", "OfficeAddressId", "dbo.OfficeAddresses");
            DropForeignKey("dbo.HomeAddresses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.HomePhones", "HomeAddressId", "dbo.HomeAddresses");
            DropIndex("dbo.OfficePhones", new[] { "OfficeAddressId" });
            DropIndex("dbo.OfficeAddresses", new[] { "CustomerId" });
            DropIndex("dbo.HomePhones", new[] { "HomeAddressId" });
            DropIndex("dbo.HomeAddresses", new[] { "CustomerId" });
            DropTable("dbo.OfficePhones");
            DropTable("dbo.OfficeAddresses");
            DropTable("dbo.HomePhones");
            DropTable("dbo.HomeAddresses");
            DropTable("dbo.Customers");
        }
    }
}
