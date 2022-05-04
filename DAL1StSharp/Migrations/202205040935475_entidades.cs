namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entidades : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.___Clientes", "Sucursal_IdSucursal", c => c.Int());
            CreateIndex("dbo.___Clientes", "Sucursal_IdSucursal");
            AddForeignKey("dbo.___Clientes", "Sucursal_IdSucursal", "dbo.___Sucursal", "IdSucursal");
            DropColumn("dbo.___Clientes", "dSucursal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.___Clientes", "dSucursal", c => c.Int(nullable: false));
            DropForeignKey("dbo.___Clientes", "Sucursal_IdSucursal", "dbo.___Sucursal");
            DropIndex("dbo.___Clientes", new[] { "Sucursal_IdSucursal" });
            DropColumn("dbo.___Clientes", "Sucursal_IdSucursal");
        }
    }
}
