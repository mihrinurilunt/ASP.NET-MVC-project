using CupcakeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CupcakeMVC.Controllers
{
    public class DoubleMenuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoubleMenuController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allMenus= _context.DoubleMenus.ToList();
            return View(allMenus);
        }
    }
}
