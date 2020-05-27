using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManejoDeForms.Models
{
    public class Cuenta
    {
        [Display(Name = "Id")]
        public int id { get; set; }
        [Display(Name = "NombreUsuario")]
        public string nombreUsuario { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Descripcion")]
        public string descrpcion { get; set; }
        [Display(Name = "Genero")]
        public string genero { get; set; }
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
        [Display(Name = "Lenguajes")]
        public string[] lenguajes { get; set; }
        [Display(Name = "Rol")]
        public string RolId { get; set; }


    }
}