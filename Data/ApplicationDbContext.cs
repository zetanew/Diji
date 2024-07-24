using Microsoft.EntityFrameworkCore;
using Diji.Models;

namespace Diji.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<State> States { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}