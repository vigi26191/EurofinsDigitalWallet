using Microsoft.AspNet.Identity.EntityFramework;

namespace EurofinsDigitalWallet.Entities.Domain
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public ApplicationUser User { get; set; }

        public ApplicationRole Role { get; set; }
    }
}
