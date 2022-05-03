namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicialv3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        IdSucursal = c.Int(nullable: false, identity: true),
                        Telefono = c.String(maxLength: 25),
                        Direccion = c.String(maxLength: 25),
                        CP = c.Int(nullable: false),
                        Ciudad = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.IdSucursal);
            
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        SurName = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Sucursals");
        }
    }
}
