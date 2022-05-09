namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inmigracionTablas2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CuentaClientes", "Cuenta_IdCuenta", "dbo.___Cuenta");
            DropForeignKey("dbo.CuentaClientes", "Cliente_IdCliente", "dbo.___Cliente");
            DropIndex("dbo.CuentaClientes", new[] { "Cuenta_IdCuenta" });
            DropIndex("dbo.CuentaClientes", new[] { "Cliente_IdCliente" });
            CreateTable(
                "dbo.___ClienteCuenta",
                c => new
                    {
                        IdClienteCuenta = c.Int(nullable: false, identity: true),
                        TipoCliente = c.Int(nullable: false),
                        FechaAlta = c.DateTime(nullable: false, storeType: "date"),
                        FechaBaja = c.DateTime(nullable: false, storeType: "date"),
                        Cliente_IdCliente = c.Int(),
                        Cuenta_IdCuenta = c.Int(),
                    })
                .PrimaryKey(t => t.IdClienteCuenta)
                .ForeignKey("dbo.___Cliente", t => t.Cliente_IdCliente)
                .ForeignKey("dbo.___Cuenta", t => t.Cuenta_IdCuenta)
                .Index(t => t.Cliente_IdCliente)
                .Index(t => t.Cuenta_IdCuenta);
            
            DropTable("dbo.CuentaClientes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CuentaClientes",
                c => new
                    {
                        Cuenta_IdCuenta = c.Int(nullable: false),
                        Cliente_IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cuenta_IdCuenta, t.Cliente_IdCliente });
            
            DropForeignKey("dbo.___ClienteCuenta", "Cuenta_IdCuenta", "dbo.___Cuenta");
            DropForeignKey("dbo.___ClienteCuenta", "Cliente_IdCliente", "dbo.___Cliente");
            DropIndex("dbo.___ClienteCuenta", new[] { "Cuenta_IdCuenta" });
            DropIndex("dbo.___ClienteCuenta", new[] { "Cliente_IdCliente" });
            DropTable("dbo.___ClienteCuenta");
            CreateIndex("dbo.CuentaClientes", "Cliente_IdCliente");
            CreateIndex("dbo.CuentaClientes", "Cuenta_IdCuenta");
            AddForeignKey("dbo.CuentaClientes", "Cliente_IdCliente", "dbo.___Cliente", "IdCliente", cascadeDelete: true);
            AddForeignKey("dbo.CuentaClientes", "Cuenta_IdCuenta", "dbo.___Cuenta", "IdCuenta", cascadeDelete: true);
        }
    }
}
