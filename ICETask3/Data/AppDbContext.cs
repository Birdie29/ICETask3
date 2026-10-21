using Microsoft.EntityFrameworkCore;
using ICETask3.Models;

namespace ICETask3.Data
{
    public class AppDbContext : DbContext
    {
        public class AppDbContext(
            DbContextOptions<AppDbContext> options) 
            : base(options)
        {
            
        }

    public DbSet<Student> Student {get; set;} = null!;
    }
}
