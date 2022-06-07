using Microsoft.EntityFrameworkCore;

namespace Tier2Competency2.Models
{
    public class ClothesContext : DbContext
    {
        public ClothesContext(DbContextOptions<ClothesContext> options)
            : base(options)
        {
        }

        public DbSet<ClothesItems> ClothesItems { get; set; }
    }
}

