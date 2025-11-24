using Microsoft.EntityFrameworkCore;

namespace Hotellerie_A2.Models.HotellerieModel
{
    public class HotellerieDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Hotel> Hotels { get; set; }
    }
}
