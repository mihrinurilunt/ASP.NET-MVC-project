using CupcakeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CupcakeMVC.Controllers
{
    public class DessertController : Controller
    {
        private readonly IDessertService _service;

        public DessertController(IDessertService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            //it returns list of all desserts
            var data = await _service.GetAll();
            return View(data);
        }
        //Get:Dessert/Create
        [HttpGet]
        public IActionResult Create()
        {
            Dessert dessert=new Dessert();
            return View(dessert);
        }
        [HttpPost]
        public IActionResult Create([Bind("Name,DessertPhotoURL,Description,Price")]Dessert dessert)
        {
            if (!ModelState.IsValid)
            {
                return View(dessert); 
            }
             _service.Add(dessert);
            return RedirectToAction(nameof(Index));
        }
    }
}
