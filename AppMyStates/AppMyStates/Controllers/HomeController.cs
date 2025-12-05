using System.Diagnostics;
using AppMyStates.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppMyStates.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            if (HttpContext.Session.Keys.Contains("cart"))
            {
                ViewData["cart"] = HttpContext.Session.GetString("cart");
            }


            //ViewData["str"] = Request.QueryString;
            if (Request.Query.ContainsKey("name"))
                ViewData["str"] = Request.Query["name"].ToString();


            if (Request.Query.ContainsKey("theme"))
            {
                Response.Cookies.Append("theme", Request.Query["theme"].ToString());

                ViewData["str2"] = "Cookie saved";
            }

            if (Request.Query.ContainsKey("cart"))
            {
                string cart = "";
                if (HttpContext.Session.Keys.Contains("cart"))
                {
                    cart = HttpContext.Session.GetString("cart");
                }
                HttpContext.Session.SetString("cart", cart + " " + Request.Query["cart"].ToString());

                ViewData["str3"] = "Added to session";
            }


            if (Request.Cookies.ContainsKey("theme"))
            {
                ViewData["mytheme"] = "Ваша сохраненная тема "  + Request.Cookies["theme"]?.ToString();                
            }

         

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
