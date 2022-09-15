using AspStudy2.Model;
using Microsoft.EntityFrameworkCore;

namespace AspStudy2.DAL.DataContext
{
    #pragma warning disable CS8618 // Nullable
    public class AspStudy2DbContext : DbContext
    {
        public DbSet<ActivityModel> Activity { get; set; }
        public DbSet<ActivityModel> User { get; set; }

        public AspStudy2DbContext(DbContextOptions<AspStudy2DbContext> options) : base(options) {  }
    }
}