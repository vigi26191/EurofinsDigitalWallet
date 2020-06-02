using EurofinsDigitalWallet.DAL.EntityConfigurations;
using EurofinsDigitalWallet.Entities.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace EurofinsDigitalWallet.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext() : base("EurofinsDigitalWalletContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<InvestmentType> InvestmentTypes { get; set; }

        public DbSet<Investment> Investments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("tblUsers");
            modelBuilder.Entity<ApplicationRole>().ToTable("tblRoles");
            modelBuilder.Entity<ApplicationUserRole>().ToTable("tblUserRoles");
            modelBuilder.Entity<ApplicationUserClaim>().ToTable("tblUserClaims");
            modelBuilder.Entity<ApplicationUserLogin>().ToTable("tblUserLogins");

            modelBuilder.Configurations.Add(new InvestmentTypeConfig());
            modelBuilder.Configurations.Add(new InvestmentConfig());
        }
    }
}
