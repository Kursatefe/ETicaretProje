using Data;
using Entities;
using ETicaretProje.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ETicaretProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel()
            {
                Slides = _context.Slides.ToList(),
                Categories = _context.Categories.Where(p => p.IsActive && p.IsHome).ToList(),
                Products = _context.Products.Where(p => p.IsActive && p.IsHome).ToList(),



            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [Route("hakkimizda")]
        public ActionResult About()
        {
            return View();
        }
        [Route("iletisim")]
        public ActionResult Contact()
        {
            return View();
        }
        [HttpGet]

        public ActionResult Why()
        {
            return View();
        }


        [HttpPost]
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
