namespace EurofinsDigitalWallet.DAL.Migrations
{
    using EurofinsDigitalWallet.Entities.Constants;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingInvestmentTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO tblInvestmentType(Code, Name) VALUES ('" + Constants.InvestementType.GOLD + "', '" + Constants.InvestementType.GOLD + "')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM tblInvestmentType");
        }
    }
}
