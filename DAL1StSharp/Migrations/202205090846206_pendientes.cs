namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pendientes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.___Cliente", "FechaNacimiento", c => c.DateTime(storeType: "date"));
            AddColumn("dbo.___Cliente", "Provincia", c => c.String(maxLength: 35));
        }
        
        public override void Down()
        {
            DropColumn("dbo.___Cliente", "Provincia");
            DropColumn("dbo.___Cliente", "FechaNacimiento");
        }
    }
}
