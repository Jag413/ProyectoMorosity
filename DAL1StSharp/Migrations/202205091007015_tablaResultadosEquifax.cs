namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablaResultadosEquifax : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.___ResultadoEqifax",
                c => new
                    {
                        IdResultado = c.Int(nullable: false, identity: true),
                        DocumentoId = c.String(maxLength: 4000),
                        IsOk = c.Boolean(nullable: false),
                        Informacion = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.IdResultado);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.___ResultadoEqifax");
        }
    }
}
