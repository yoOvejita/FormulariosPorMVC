using ManejoDeForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManejoDeForms.VistaModelos
{
    public class VistaModeloCuenta
    {
        public Cuenta cuenta { get; set; }
        public List<Lenguaje> lenguajes{ get; set; }//Lista toatl de lenguajes diponibles
        public List<Lenguaje> lenguajesSeleccionados { get; set; }//Lista de lenguajes del usuario nuevo
        public List<SelectListItem> Roles { get; set; }

    }
}