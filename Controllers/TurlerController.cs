using Microsoft.AspNetCore.Mvc;
using Barinak.Odev.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Barinak.Odev.Controllers
{
    
    public class TurlerController : Controller
    {
      
        Context c=new Context();
        [Authorize]
        public IActionResult Index()

        {
            var degerler = c.Turlers.ToList();
            return View(degerler);
        }
        [HttpGet]
        
        public IActionResult YeniTur()
        {
            var degerler = c.Turlers.ToList();
            return View();
           
        }
        [HttpPost]
        public IActionResult YeniTur(Turler T)
        {
            c.Turlers.Add(T);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        
        public IActionResult TurSil(int id)
        { 
            var tur = c.Turlers.Find(id);
            c.Turlers.Remove(tur);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult TurListe(int id)
        {
            var degerler=c.Hayvanlars.Where(x=>x.Turid== id).ToList();

            return View(degerler);
        }
    }
}
