using Microsoft.EntityFrameworkCore;

namespace Mod.Plkn.Web.ApiServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
