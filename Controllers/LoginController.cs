using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Barinak.Odev.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Barinak.Odev.Controllers
{
	public class LoginController : Controller
	{
		Context c = new Context();

		public IActionResult GirisYap()
		{
			ClaimsPrincipal claimUser = HttpContext.User;

			if (claimUser.Identity.IsAuthenticated)
				return RedirectToAction("Index", "Home");

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> GirisYap(Admin modelLogin)
		{        

            if (modelLogin.Kullanici == "g211210376@sakarya.edu.tr" &&
				modelLogin.Sifre == "sau")
			{
				List<Claim> claims = new List<Claim>
				{
					new Claim(ClaimTypes.NameIdentifier,modelLogin.Kullanici),
  
                    new Claim("OtherProperties","Example Role")

				};

				ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
				CookieAuthenticationDefaults.AuthenticationScheme);

				AuthenticationProperties properties = new AuthenticationProperties()
				{
					AllowRefresh = true,
					IsPersistent = modelLogin.KeepLoggedIn
				};


				await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
					new ClaimsPrincipal(claimsIdentity), properties);

				return RedirectToAction("GirisYap", "Login");

			}


			ViewData["ValidateMessage"] = "user not found";

			return View();
		}
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("GirisYap", "Login");
		}
	}
}

