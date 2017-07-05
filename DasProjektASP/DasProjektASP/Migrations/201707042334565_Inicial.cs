namespace DasProjektASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Telefone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        ReservaID = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        ServicoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservaID)
                .ForeignKey("dbo.Clientes", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Servicoes", t => t.ServicoID, cascadeDelete: true)
                .Index(t => t.ServicoID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Servicoes",
                c => new
                    {
                        ServicoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ServicoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "ServicoID", "dbo.Servicoes");
            DropForeignKey("dbo.Reservas", "ClienteID", "dbo.Clientes");
            DropIndex("dbo.Reservas", new[] { "ClienteID" });
            DropIndex("dbo.Reservas", new[] { "ServicoID" });
            DropTable("dbo.Servicoes");
            DropTable("dbo.Reservas");
            DropTable("dbo.Clientes");
        }
    }
}
