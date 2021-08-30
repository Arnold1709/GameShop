using Microsoft.AspNetCore.Mvc;
using GameShop.Models;
using GameShop.Data;

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
            return View();
        }
      

         public IActionResult Create(Producto objProducto)
        {

            _context.Add(objProducto);
            _context.SaveChanges();
            ViewData["Message"] = "El producto ya esta registrado";
            return View("Index");
        }
     /*[HttpPost]*/
        /*    public IActionResult Oferta (Producto objproducto)
        {


             decimal operacion=0;
            ViewData["Message"] = "Sin resultado";
            if(((long)objproducto.precio)>0){
                operacion =objproducto.precio- (objproducto.precio * (objproducto.descuento/100));
                ViewData["Message"] = "El precio a pagar es "+ operacion;
            }else{
                ViewData["Message"] = "Sin resultado";
            }
            return View("index");
                
        }
        */
    }

}