using Microsoft.EntityFrameworkCore;

namespace Hotsite.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Interesse> Interesses { get; set; }
    }
}