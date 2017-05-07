using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace modeloParcial.MVC.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: /Home/

        public ActionResult ListarEjercicios() {

            List<modeloParcial.MVC.Models.NuevoEjercicio> e = Servicios.EjercicioServicios.EjerciciosStatic;
            return View(e);
        }
        
        public ActionResult Nuevo() {
            List<Models.TipoEj> tipos = Servicios.EjercicioServicios.devolverTipos();
            List<Models.NivelEsfuerzo> Ne = Servicios.EjercicioServicios.devovlerNe();

            ViewBag.Tipo = tipos;
            ViewBag.Ne = Ne;
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(Models.NuevoEjercicio model) {

            List<Models.TipoEj> tipos = Servicios.EjercicioServicios.devolverTipos();
            List<Models.NivelEsfuerzo> Ne = Servicios.EjercicioServicios.devovlerNe();

            ViewBag.Tipo = tipos;
            ViewBag.Ne = Ne;

            if (!ModelState.IsValid) {
                return View(model);
            }

            Servicios.EjercicioServicios.EjerciciosStatic.Add(model);

            ViewBag.Message = "el Ejercicio " + model.Nombre + " ha sido agregado correctamente";

            return View();

                
        }
        
        

    }
}