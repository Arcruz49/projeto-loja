using Microsoft.AspNetCore.Mvc;
using siteLoja.Models;
using System.Diagnostics;

namespace siteLoja.Controllers
{
    public class HomeController : Controller
    {

        private shopDBContext db = new shopDBContext();

        public IActionResult Index()
        {
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
