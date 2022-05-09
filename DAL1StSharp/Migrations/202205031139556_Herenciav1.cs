namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Herenciav1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Sucursals", newName: "Sucursal");
            AddColumn("dbo.Sucursal", "IdUsuarioInsercion", c => c.Int(nullable: false));
            AddColumn("dbo.Sucursal", "FechaInsercion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sucursal", "FechaUltimaActualizacion", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sucursal", "FechaUltimaActualizacion");
            DropColumn("dbo.Sucursal", "FechaInsercion");
            DropColumn("dbo.Sucursal", "IdUsuarioInsercion");
            RenameTable(name: "dbo.Sucursal", newName: "Sucursals");
        }
    }
}
