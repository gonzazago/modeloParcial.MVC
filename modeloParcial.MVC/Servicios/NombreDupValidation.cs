using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace modeloParcial.MVC.Servicios
{
    public class NombreDupValidation : ValidationAttribute 
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string nombre = (string)value;
            
            List<modeloParcial.MVC.Models.NuevoEjercicio> listEj = Servicios.EjercicioServicios.EjerciciosStatic;
            string message = string.Empty;

            foreach (var le in listEj)
            {
                if(nombre == le.Nombre)
                {
                    message = "El nombre ingresado se encuentra en Uso";
                    return new ValidationResult(message);
                }
            }

            return ValidationResult.Success;
        }
    }
}