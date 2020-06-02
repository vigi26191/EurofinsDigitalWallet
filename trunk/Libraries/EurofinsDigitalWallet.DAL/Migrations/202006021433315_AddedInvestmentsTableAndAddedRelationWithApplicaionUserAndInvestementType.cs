namespace EurofinsDigitalWallet.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInvestmentsTableAndAddedRelationWithApplicaionUserAndInvestementType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblInvestments",
                c => new
                    {
                        InvestmentId = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        InvestmentDate = c.DateTime(nullable: false),
                        TotalGramsPurchased = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PricePerGram = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GSTAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmountPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApplicationUserId = c.Int(nullable: false),
                        InvestmentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvestmentId)
                .ForeignKey("dbo.tblUsers", t => t.ApplicationUserId)
                .ForeignKey("dbo.tblInvestmentType", t => t.InvestmentTypeId)
                .Index(t => t.ApplicationUserId)
                .Index(t => t.InvestmentTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblInvestments", "InvestmentTypeId", "dbo.tblInvestmentType");
            DropForeignKey("dbo.tblInvestments", "ApplicationUserId", "dbo.tblUsers");
            DropIndex("dbo.tblInvestments", new[] { "InvestmentTypeId" });
            DropIndex("dbo.tblInvestments", new[] { "ApplicationUserId" });
            DropTable("dbo.tblInvestments");
        }
    }
}
