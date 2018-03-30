namespace E_ATMMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class someupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AccountModels", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AccountModels", "Name", c => c.String());
        }
    }
}
