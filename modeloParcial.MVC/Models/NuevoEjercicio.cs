using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using modeloParcial.MVC.Servicios;

namespace modeloParcial.MVC.Models
{
    public class NuevoEjercicio
    {
        [Required(ErrorMessage ="Debe Introducir un Nombre")]
        [NombreDupValidation]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Debe introduccir la descripcion del Ejercicio"),MaxLength(500)]
        public string Indicaciones { get; set; }
        [Required(ErrorMessage ="Debe seleccionar un tipo")]
        public string tipo { get; set; }
        public string nivelEsfuerzo { get; set; }
        public List<NuevoEjercicio> ejerciciosCreados { get; set; }

     }
}