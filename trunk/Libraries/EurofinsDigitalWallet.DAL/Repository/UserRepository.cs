using EurofinsDigitalWallet.DAL.Concretes;
using EurofinsDigitalWallet.Entities.Domain;
using EurofinsDigitalWallet.IRepositories;

namespace EurofinsDigitalWallet.DAL.Repository
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        public ApplicationDbContext DataContext { get { return Context as ApplicationDbContext; } }

        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
