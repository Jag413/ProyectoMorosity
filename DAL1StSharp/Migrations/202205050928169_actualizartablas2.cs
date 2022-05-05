namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizartablas2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.___Cliente", "Provincia", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.___Cliente", "Provincia");
        }
    }
}
