using Microsoft.EntityFrameworkCore;
namespace EntityFramework.EntityData
{
    //public class EntityDb:DbContextBase
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext()
        {
        }

        public DbContext(DbContextOptions<DbContext> options) : base(options) { }
    }
}