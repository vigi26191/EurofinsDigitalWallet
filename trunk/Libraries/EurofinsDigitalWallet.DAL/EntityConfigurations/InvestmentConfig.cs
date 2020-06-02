using EurofinsDigitalWallet.Entities.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EurofinsDigitalWallet.DAL.EntityConfigurations
{
    public class InvestmentConfig : EntityTypeConfiguration<Investment>
    {
        public InvestmentConfig()
        {
            ToTable("tblInvestments").HasKey(a => a.InvestmentId);

            Property(p => p.InvestmentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(a => a.ApplicationUser).WithMany(ot => ot.Investments).HasForeignKey(a => a.ApplicationUserId).WillCascadeOnDelete(false);

            HasRequired(a => a.InvestmentType).WithMany(ot => ot.Investments).HasForeignKey(a => a.InvestmentTypeId).WillCascadeOnDelete(false);

            Property(p => p.InvestmentDate).IsRequired();

            Property(p => p.TotalGramsPurchased).IsRequired();

            Property(p => p.PricePerGram).IsRequired();

            Property(p => p.GSTAmount).IsRequired();

            Property(p => p.TotalAmountPaid).IsRequired();
        }
    }
}
