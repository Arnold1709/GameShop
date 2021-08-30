using Microsoft.AspNetCore.Mvc;
using GameShop.Models;
using GameShop.Data;
using System.Linq;

namespace GameShop.Controllers
{
    public class ProductoController:Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

         public IActionResult Index()
        {
           return View(_context.DataProductos.ToList());
        }
      
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Create(Producto objProducto)
        {

            _context.Add(objProducto);
            _context.SaveChanges();
            ViewData["Message"] = "El producto ya esta registrado";
            return View();
        }
     
    }

}