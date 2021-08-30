using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{
    [Table("t_producto")]
    public class Producto
    {
    
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int id {get; set;}
         [Column("nombre")]
        public string nombre{ get; set; }
         [Column("precio")]
        public decimal precio {get; set;}
         [Column("descuento")]
        public decimal descuento {get; set;}
         [Column("categoria")]
        public string categoria {get; set;}

    }
}
