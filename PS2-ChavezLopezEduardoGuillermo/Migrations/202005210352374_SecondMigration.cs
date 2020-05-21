namespace PS2_ChavezLopezEduardoGuillermo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "TipoAlimento", c => c.String());
            AlterColumn("dbo.Menus", "Alimento", c => c.String());
            AlterColumn("dbo.Menus", "Status", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.Menus", "Alimento", c => c.Int(nullable: false));
            AlterColumn("dbo.Menus", "TipoAlimento", c => c.Int(nullable: false));
        }
    }
}
