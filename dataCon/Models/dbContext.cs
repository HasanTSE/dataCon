using Microsoft.EntityFrameworkCore;

namespace dataCon.Models
{
    public class dbContext:DbContext

    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
            {
            
            }

        public DbSet<dataConnec> dataConnecs { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Semester> Semesters { get; set; }
    }
}
