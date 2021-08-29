using Microsoft.AspNetCore.Mvc;
using GameShop.Models;

namespace GameShop.Controllers
{
    public class ProductoController:Controller
    {
         public IActionResult Index()
        {
            return View();
        }

     [HttpPost]
         public IActionResult Oferta (Producto objproducto)
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

    }

}