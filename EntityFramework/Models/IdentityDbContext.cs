using Microsoft.EntityFrameworkCore;

namespace EntityFramework.EntityData
{
    public class IdentityDbContext
    {
        private DbContextOptions<DbContext> options;

        public IdentityDbContext(DbContextOptions<DbContext> options)
        {
            this.options = options;
        }
    }
}