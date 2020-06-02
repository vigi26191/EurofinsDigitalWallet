using System;

namespace EurofinsDigitalWallet.Entities.Domain
{
    public class Investment
    {
        public Investment()
        {
            CreatedDate = DateTime.Now;
        }

        public DateTime CreatedDate { get; set; }

        public int InvestmentId { get; set; }

        public DateTime InvestmentDate { get; set; }

        public decimal TotalGramsPurchased { get; set; }

        public decimal PricePerGram { get; set; }

        public decimal GSTAmount { get; set; }

        public decimal TotalAmountPaid { get; set; }

        #region Navigation Properties
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int InvestmentTypeId { get; set; }
        public InvestmentType InvestmentType { get; set; }
        #endregion
    }
}
