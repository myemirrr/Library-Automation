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
            if(ModelState.IsValid) 
            {
                _uygulamaDbContext.KitapTurleri.Add(kitapTuru);
                _uygulamaDbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }


        public IActionResult Guncelle() 
		{
			return View();
		}


		public IActionResult Sil()
		{
			return View();
		}
	}
}
