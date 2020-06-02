using EurofinsDigitalWallet.DAL.Concretes;
using EurofinsDigitalWallet.Entities.Domain;
using EurofinsDigitalWallet.IRepositories;

namespace EurofinsDigitalWallet.DAL.Repository
{
    public class InvestmentRepository : Repository<Investment>, IInvestmentRepository
    {
        public ApplicationDbContext DataContext { get { return Context as ApplicationDbContext; } }

        public InvestmentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
