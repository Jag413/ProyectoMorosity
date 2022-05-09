namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inmigracionTablas4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.___Peticion", "IsOk", c => c.Boolean(nullable: false));
            AddColumn("dbo.___Peticion", "Razones", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.___Peticion", "Razones");
            DropColumn("dbo.___Peticion", "IsOk");
        }
    }
}
