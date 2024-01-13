using Library.EF;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class KitapTuruController : Controller
    {
        //Dependency Injection
        private readonly UygulamaDbContext _uygulamaDbContext;
       


        public KitapTuruController(UygulamaDbContext context)
        {
            _uygulamaDbContext = context;
        }

        public IActionResult Index()
        {
            List<KitapTuru> objKitapTuruList=_uygulamaDbContext.KitapTurleri.ToList();
            return View(objKitapTuruList);
        }

        public IActionResult Ekle()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Ekle(KitapTuru kitapTuru)
        {
            if (ModelState.IsValid)
            {
                _uygulamaDbContext.KitapTurleri.Add(kitapTuru);
                _uygulamaDbContext.SaveChanges();
                TempData["basarili"] = "Yeni Kitap Türü Oluşturuldu !";
                return RedirectToAction("Index", "KitapTuru");
            }
            return View();
        }


        public IActionResult Guncelle(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            KitapTuru? kitapTuruVt = _uygulamaDbContext.KitapTurleri.Find(id);  
            if (kitapTuruVt == null)
            {
                return NotFound();
            }
            return View(kitapTuruVt);
        }




        [HttpPost]
        public IActionResult Guncelle(KitapTuru kitapTuru)
        {
            if (ModelState.IsValid)
            {
                _uygulamaDbContext.KitapTurleri.Update(kitapTuru);
                _uygulamaDbContext.SaveChanges();
                TempData["basarili"] = "Kitap Türü Güncellendi !";
                return RedirectToAction("Index");
            }
            return View();
        }


        
        public IActionResult Sil(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            KitapTuru? kitapTuruVt = _uygulamaDbContext.KitapTurleri.Find(id);
            if (kitapTuruVt == null)
            {
                return NotFound();
            }
            return View(kitapTuruVt);
        }


        [HttpPost, ActionName("Sil")]
        public IActionResult SilPost(int? id)
        {
            KitapTuru? kitapTuru = _uygulamaDbContext.KitapTurleri.Find(id);
            if (kitapTuru == null)
            {
                return NotFound();
            }
            _uygulamaDbContext.KitapTurleri.Remove(kitapTuru);
            _uygulamaDbContext.SaveChanges();
            TempData["basarili"] = "Kitap Türü Silindi !";
            return RedirectToAction("Index");
        }
    }
}
