namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablaResultadosEquifax1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.___ResultadoEqifax", "IsOk");
        }
        
        public override void Down()
        {
            AddColumn("dbo.___ResultadoEqifax", "IsOk", c => c.Boolean(nullable: false));
        }
    }
}
