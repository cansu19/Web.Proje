
using Microsoft.AspNetCore.Mvc;
using Barinak.Odev.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Barinak.Odev.Controllers
{
    public class Information : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
