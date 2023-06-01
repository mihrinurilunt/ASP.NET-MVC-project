using CupcakeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CupcakeMVC.Controllers
{
    public class DrinksController : Controller
    {
        private readonly IDrinksService _service;

        public DrinksController(IDrinksService service)
        {
            _service = service;
        }
        public async Task< IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Drinks drinks = new Drinks();
            return View(drinks);
        }
        [HttpPost]
        public IActionResult Create([Bind("Name,DrinkPhotoURL,Description,Price")] Drinks drinks)
        {
            if (!ModelState.IsValid)
            {
                return View(drinks);
            }
            _service.Add(drinks);
            return RedirectToAction(nameof(Index));
        }
    }
}
