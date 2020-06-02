using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace EurofinsDigitalWallet.Entities.Domain
{
    public class ApplicationRole : IdentityRole<int, ApplicationUserRole>
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
