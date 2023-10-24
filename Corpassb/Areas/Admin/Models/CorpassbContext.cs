using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Corpassb.Areas.Admin.Models
{
    public class CorpassbContext: IdentityDbContext<User>
    {
        public CorpassbContext(DbContextOptions<CorpassbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
