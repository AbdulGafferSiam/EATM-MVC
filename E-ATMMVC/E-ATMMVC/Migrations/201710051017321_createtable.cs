namespace E_ATMMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountModels",
                c => new
                    {
                        CardNumber = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PinNumber = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CardNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountModels");
        }
    }
}
