using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.EF
{
    public class UygulamaDbContext:IdentityDbContext

    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
 
        }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<KitapTuru> KitapTurleri { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

       
    }
}
