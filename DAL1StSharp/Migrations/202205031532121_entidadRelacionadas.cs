namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidadRelacionadas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Sucursal", newName: "___Sucursal");
            CreateTable(
                "dbo.___Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        DocumentoId = c.String(maxLength: 10),
                        RazonSocial = c.String(maxLength: 50),
                        Nombre = c.String(maxLength: 20),
                        Apellidos = c.String(maxLength: 25),
                        Nacionalidad = c.String(maxLength: 20),
                        Telefono = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        Direccion = c.String(maxLength: 250),
                        CP = c.String(maxLength: 5),
                        Ciudad = c.String(maxLength: 25),
                        dSucursal = c.Int(nullable: false),
                        IdUsuarioInsercion = c.Int(),
                        FechaInsercion = c.DateTime(nullable: false),
                        FechaUltimaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.___Peticion",
                c => new
                    {
                        IdPeticion = c.Int(nullable: false, identity: true),
                        Estado = c.String(maxLength: 20),
                        IdUsuarioInsercion = c.Int(),
                        FechaInsercion = c.DateTime(nullable: false),
                        FechaUltimaActualizacion = c.DateTime(nullable: false),
                        Cliente_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.IdPeticion)
                .ForeignKey("dbo.___Clientes", t => t.Cliente_IdCliente)
                .Index(t => t.Cliente_IdCliente);
            
            AlterColumn("dbo.___Sucursal", "IdUsuarioInsercion", c => c.Int());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.___Peticion", "Cliente_IdCliente", "dbo.___Clientes");
            DropIndex("dbo.___Peticion", new[] { "Cliente_IdCliente" });
            AlterColumn("dbo.___Sucursal", "IdUsuarioInsercion", c => c.Int(nullable: false));
            DropTable("dbo.___Peticion");
            DropTable("dbo.___Clientes");
            RenameTable(name: "dbo.___Sucursal", newName: "Sucursal");
        }
    }
}
