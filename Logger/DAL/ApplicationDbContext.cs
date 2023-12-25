using Logger.Entities;
using Microsoft.EntityFrameworkCore;

namespace Logger.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<TestLogger> testLoggers { get; set; }
    }
}
