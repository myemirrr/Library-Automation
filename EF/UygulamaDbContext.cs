using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.EF
{
    public class UygulamaDbContext:DbContext

    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
 
        }
        public DbSet<KitapTuru> KitapTurleri { get; set; }
    }
}
