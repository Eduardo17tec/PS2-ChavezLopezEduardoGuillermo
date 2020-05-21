using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PS2_ChavezLopezEduardoGuillermo.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Display(Name = "Tipo de alimento")]
        public string TipoAlimento { get; set; }
        [Display(Name = "Alimento")]
        public string Alimento { get; set; }
        [Display(Name = "Precio")]
        public float Precio { get; set; }
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
        [Display(Name = "Estatus")]
        public string Status { get; set; }
    }
}