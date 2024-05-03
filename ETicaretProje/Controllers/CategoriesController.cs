using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicaretProje.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            if (id is null)
            {
                return BadRequest();
            }
            var categories = _context.Categories.Include(p => p.Products).FirstOrDefault(k => k.Id == id); 
            if (categories == null)
                return NotFound();

            return View(categories);
        }
    }
}

