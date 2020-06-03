using EurofinsDigitalWallet.DAL;
using EurofinsDigitalWallet.DAL.Concretes;
using System.Linq;

namespace EurofinsDigitalWallet.BAL
{
    public class DigitalWalletBAL
    {
        int transactionCharges = 100;

        public void GetSaleDetails(decimal currentGoldRatePerGram, out bool isProfit, out decimal averageGramPrice)
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                decimal averagePricePerGram = unitOfWork.Investments.GetAll().Average(a => a.PricePerGram);

                isProfit = currentGoldRatePerGram > averagePricePerGram ? true : false;
                averageGramPrice = averagePricePerGram;
            }
        }

        public string GetSaleShareValue(decimal currentGoldRatePerGram, decimal goldQuantityToSell, out decimal saleValue)
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                decimal averagePricePerGram = unitOfWork.Investments.GetAll().Average(a => a.PricePerGram);
                decimal averageTotalAmountSpent = unitOfWork.Investments.GetAll().Average(a => a.TotalAmountPaid);

                var shareValue = (currentGoldRatePerGram * goldQuantityToSell) - (goldQuantityToSell * transactionCharges) - averageTotalAmountSpent;
                shareValue = (shareValue * 100) / averageTotalAmountSpent;

                saleValue = shareValue;

                return shareValue.ToString("0.0%");
            }
        }
    }
}
