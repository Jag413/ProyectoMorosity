namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialDbPruebas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        IdSucursal = c.Int(nullable: false, identity: true),
                        Telefono = c.String(maxLength: 15),
                        Direccion = c.String(maxLength: 250),
                        CP = c.String(maxLength: 5),
                        Ciudad = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.IdSucursal);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sucursals");
        }
    }
}
