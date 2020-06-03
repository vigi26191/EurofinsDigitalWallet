using EurofinsDigitalWallet.DAL.Repository;
using EurofinsDigitalWallet.IRepositories;
using EurofinsDigitalWallet.IRepositories.Contracts;
using System;

namespace EurofinsDigitalWallet.DAL.Concretes
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Initialize();
        }

        public IUserRepository Users { get; set; }

        public IInvestmentRepository Investments { get; set; }

        public void Initialize()
        {
            Users = new UserRepository(_context);
            Investments = new InvestmentRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
