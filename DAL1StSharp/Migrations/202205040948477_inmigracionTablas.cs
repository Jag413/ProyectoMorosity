namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inmigracionTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.___Clientes", newName: "___Cliente");
            CreateTable(
                "dbo.___Cuenta",
                c => new
                    {
                        IdCuenta = c.Int(nullable: false, identity: true),
                        NumCuenta = c.String(maxLength: 24),
                        Saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdUsuarioInsercion = c.Int(),
                        FechaInsercion = c.DateTime(nullable: false),
                        FechaUltimaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCuenta);
            
            CreateTable(
                "dbo.___Movimiento",
                c => new
                    {
                        IdMovimiento = c.Int(nullable: false, identity: true),
                        FechaValor = c.DateTime(nullable: false, storeType: "date"),
                        FechaOperacion = c.DateTime(nullable: false, storeType: "date"),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Titulo = c.String(maxLength: 30),
                        Descripcion = c.String(maxLength: 3000),
                        IdUsuarioInsercion = c.Int(),
                        FechaInsercion = c.DateTime(nullable: false),
                        FechaUltimaActualizacion = c.DateTime(nullable: false),
                        Cuenta_IdCuenta = c.Int(),
                    })
                .PrimaryKey(t => t.IdMovimiento)
                .ForeignKey("dbo.___Cuenta", t => t.Cuenta_IdCuenta)
                .Index(t => t.Cuenta_IdCuenta);
            
            CreateTable(
                "dbo.___Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        NumUsuario = c.Long(nullable: false),
                        Password = c.String(maxLength: 4000),
                        Sucursal_IdSucursal = c.Int(),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.___Sucursal", t => t.Sucursal_IdSucursal)
                .Index(t => t.Sucursal_IdSucursal);
            
            CreateTable(
                "dbo.CuentaClientes",
                c => new
                    {
                        Cuenta_IdCuenta = c.Int(nullable: false),
                        Cliente_IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cuenta_IdCuenta, t.Cliente_IdCliente })
                .ForeignKey("dbo.___Cuenta", t => t.Cuenta_IdCuenta, cascadeDelete: true)
                .ForeignKey("dbo.___Cliente", t => t.Cliente_IdCliente, cascadeDelete: true)
                .Index(t => t.Cuenta_IdCuenta)
                .Index(t => t.Cliente_IdCliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.___Usuario", "Sucursal_IdSucursal", "dbo.___Sucursal");
            DropForeignKey("dbo.___Movimiento", "Cuenta_IdCuenta", "dbo.___Cuenta");
            DropForeignKey("dbo.CuentaClientes", "Cliente_IdCliente", "dbo.___Cliente");
            DropForeignKey("dbo.CuentaClientes", "Cuenta_IdCuenta", "dbo.___Cuenta");
            DropIndex("dbo.CuentaClientes", new[] { "Cliente_IdCliente" });
            DropIndex("dbo.CuentaClientes", new[] { "Cuenta_IdCuenta" });
            DropIndex("dbo.___Usuario", new[] { "Sucursal_IdSucursal" });
            DropIndex("dbo.___Movimiento", new[] { "Cuenta_IdCuenta" });
            DropTable("dbo.CuentaClientes");
            DropTable("dbo.___Usuario");
            DropTable("dbo.___Movimiento");
            DropTable("dbo.___Cuenta");
            RenameTable(name: "dbo.___Cliente", newName: "___Clientes");
        }
    }
}
