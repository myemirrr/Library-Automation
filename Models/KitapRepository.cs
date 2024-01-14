using Library.EF;
using Microsoft.AspNetCore.Identity;

namespace Library.Models
{
    public class KitapRepository : Repository<Kitap>, IKitapRepository
    {
        private UygulamaDbContext _uygulamaDbContext;
        public KitapRepository(UygulamaDbContext uygulamaDbContext) : base(uygulamaDbContext)
        {
            _uygulamaDbContext = uygulamaDbContext;
        }

        public void Guncelle(Kitap kitap)
        {
            _uygulamaDbContext.Update(kitap);
        }

        public void Guncelle(KitapTuru kitapTuru)
        {
            throw new NotImplementedException();
        }

        public void Kaydet()
        {
            _uygulamaDbContext.SaveChanges();
        }

        public List<IdentityUser> GetUsers()
        {
            var users = _uygulamaDbContext.Users.ToList();
            return users;
        }
    }
}

