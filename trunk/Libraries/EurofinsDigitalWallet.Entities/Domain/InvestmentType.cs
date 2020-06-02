using System.Collections.Generic;

namespace EurofinsDigitalWallet.Entities.Domain
{
    public class InvestmentType
    {
        public InvestmentType()
        {
            Investments = new HashSet<Investment>();
        }

        public int InvestmentTypeId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        #region Navigation Properties
        public ICollection<Investment> Investments { get; set; }
        #endregion
    }
}
