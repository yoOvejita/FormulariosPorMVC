using ManejoDeForms.Models;
using ManejoDeForms.VistaModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManejoDeForms.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        [HttpGet]
        public ActionResult Index()
        {
            VistaModeloCuenta vmCuenta = new VistaModeloCuenta();
            vmCuenta.cuenta = new Cuenta { id = 334, genero = "varon", Estado = true};
            vmCuenta.lenguajes = new List<Lenguaje>() {
                new Lenguaje{ id = "len01", nombre = "C#"},
                new Lenguaje{ id = "len02", nombre = "C++"},
                new Lenguaje{ id = "len03", nombre = "C"},
                new Lenguaje{ id = "len04", nombre = "Java"},
                new Lenguaje{ id = "len05", nombre = "Python"},
                new Lenguaje{ id = "len06", nombre = "F#"},
                new Lenguaje{ id = "len07", nombre = "ASM"}
            };
            vmCuenta.lenguajesSeleccionados = new List<Lenguaje>() {
                new Lenguaje{ id = "len03", nombre = "C"},
                new Lenguaje{ id = "len07", nombre = "ASM"}
            };
            vmCuenta.Roles = new List<SelectListItem>() {
                new SelectListItem{ Value = "r01", Text="Depurador"},
                new SelectListItem{ Value = "r02", Text="Desarrollador"},
                new SelectListItem{ Value = "r03", Text="QA"}
            };
            return View("Index", vmCuenta);
        }

        [HttpPost]
        public ActionResult Registro(VistaModeloCuenta vmCuentaCambiada) {
            ViewBag.cucu = vmCuentaCambiada.cuenta;
            return View("Success");
        }
    }
}