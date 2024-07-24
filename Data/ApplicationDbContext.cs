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

        public DbSet<Test> Test { get; set; }
    }
}