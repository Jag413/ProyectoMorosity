namespace DAL1StSharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicialv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "SurName", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "SurName");
        }
    }
}
