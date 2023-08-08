using Microsoft.AspNetCore.Mvc;
using Barinak.Odev.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Barinak.Odev.Controllers
{

    public class HayController : Controller
    {
       
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Hayvanlars.Include(x => x.Turler).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniHayvan()
        {
            List<SelectListItem> degerler = (from x in c.Turlers.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.TurAd,
                                                 Value = x.turid.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        public IActionResult YeniHayvan(Hayvanlar h)
        {

            var hayvan = c.Turlers.Where(x => x.turid == h.Turid).FirstOrDefault();
            h.Turler = hayvan;
            c.Hayvanlars.Add(h);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult HayvanSil(int id)
        {
            var hay = c.Hayvanlars.Find(id);
            c.Hayvanlars.Remove(hay);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult HayvanDetay(int id)
        {
            var deger = c.Hayvanlars.Find(id);
            return View(deger);
        }

        public IActionResult HayvanSahiplen(int id)
        {
            var b = c.Hayvanlars.Find(id);
            b.sahiplenmeDurum="sahipli";
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Vazgec(int id)
        {
            var b = c.Hayvanlars.Find(id);
            b.sahiplenmeDurum = "sahipsiz";
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


