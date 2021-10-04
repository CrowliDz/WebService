using Microsoft.EntityFrameworkCore;
using WebService.Entities;

namespace WebService.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }


    }
}
