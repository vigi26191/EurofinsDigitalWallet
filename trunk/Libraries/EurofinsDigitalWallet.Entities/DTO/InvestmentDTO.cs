using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EurofinsDigitalWallet.Entities.DTO
{
    public class InvestmentDTO
    {
        public DateTime InvestmentDate { get; set; }

        public decimal TotalGramsPurchased { get; set; }

        public decimal PricePerGram { get; set; }

        public decimal GSTAmount { get; set; }

        public decimal TotalAmountPaid { get; set; }
    }
}
