using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS2_ChavezLopezEduardoGuillermo.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Clave de la Orden")]
        public string Clave { get; set; }
        [Display(Name = "Nombre del Cliente")]
        public string Cliente { get; set; }
        [Display(Name = "Estatus")]
        public string Status { get; set; }
        public int MenuId { get; set; }
        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }
    }
}