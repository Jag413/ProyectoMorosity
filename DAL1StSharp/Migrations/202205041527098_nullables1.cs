namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullables1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.___Cliente", "Movil", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            DropColumn("dbo.___Cliente", "Movil");
        }
    }
}
