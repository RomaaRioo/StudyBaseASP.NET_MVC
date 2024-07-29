using Microsoft.EntityFrameworkCore;
using WebASP.NET_study.Models;

namespace WebASP.NET_study.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {     
        }

        public DbSet<Category> Categories { get; set; }
    }
}
