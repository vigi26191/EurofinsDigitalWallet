namespace EurofinsDigitalWallet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInvestmentTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblInvestmentType",
                c => new
                    {
                        InvestmentTypeId = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 20, unicode: false),
                        Name = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.InvestmentTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblInvestmentType");
        }
    }
}
