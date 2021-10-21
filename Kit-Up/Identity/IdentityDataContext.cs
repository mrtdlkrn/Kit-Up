using Microsoft.AspNet.Identity.EntityFramework;

namespace Kit_Up.Identity
{
    public class IdentityDataContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext() : base("dataConnection")
        {

        }
    }
}