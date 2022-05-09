namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.___ClienteCuenta", "FechaBaja", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.___ClienteCuenta", "FechaBaja", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
