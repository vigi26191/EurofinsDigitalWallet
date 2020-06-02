using EurofinsDigitalWallet.Entities.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EurofinsDigitalWallet.DAL.EntityConfigurations
{
    public class InvestmentTypeConfig : EntityTypeConfiguration<InvestmentType>
    {
        public InvestmentTypeConfig()
        {
            ToTable("tblInvestmentType").HasKey(a => a.InvestmentTypeId);

            Property(p => p.InvestmentTypeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Code).IsRequired().HasColumnType("varchar").HasMaxLength(20);

            Property(p => p.Name).IsRequired().HasColumnType("varchar").HasMaxLength(20);
        }
    }
}
