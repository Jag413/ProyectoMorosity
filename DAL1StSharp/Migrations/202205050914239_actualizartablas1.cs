namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizartablas1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.___Cliente", "FechaNacimiento", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.___Cliente", "FechaNacimiento");
        }
    }
}
