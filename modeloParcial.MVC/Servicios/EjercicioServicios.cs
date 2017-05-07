using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using modeloParcial.MVC.Models;

namespace modeloParcial.MVC.Servicios
{
    public class EjercicioServicios
    {
        //public static Dictionary<int, string> tipo = new Dictionary<int, string>()
        //{ { 1,"Pecho" },{ 2 ,"Espalda"},{3,"Hombro" } ,{4,"Piernas"} };



        public static Dictionary<int, string> NivelEsfuerzo = new Dictionary<int, string>()
        { { 1,"Bajo"}, { 2,"Medio"}, { 3,"Alto"} };

        public static List<NuevoEjercicio> EjerciciosStatic = new List<NuevoEjercicio>()
        {    new NuevoEjercicio() {
                    Nombre ="Remo",
                    Indicaciones="Indicaciones de Remo",
                    tipo = "Pecho",
                    nivelEsfuerzo = "Medio"


                }



            
        };

        public static List<TipoEj> tipoStatic = new List<TipoEj>()
        {
            new TipoEj()
            {
                id = 1,
                desc ="Pecho"
            },
            new TipoEj()
            {
                id = 2,
                desc = "Espalda"
            },
            new TipoEj()
            {
                id = 3,
                desc ="Hombros"
            },
            new TipoEj()
            {
                id = 3,
                desc ="Hombros"
            }

        };

        public static List<NivelEsfuerzo> neStatic = new List<NivelEsfuerzo>()
        {
            new NivelEsfuerzo()
            {
                id = 1,
                desc ="Facil"
            },
            new NivelEsfuerzo()
            {
                id = 3,
                desc ="Medio"
            },
            new NivelEsfuerzo()
            {
                id = 2,
                desc ="Dificil"
            },

        };

        public static List<NuevoEjercicio> obtenerTodos()
        {
            return EjerciciosStatic;
        }

        public static void agregarEjercicio(NuevoEjercicio e)
        {
            EjerciciosStatic.Add(e);
        }

        public static List<TipoEj> devolverTipos()
        {
            return tipoStatic;
        }

        public static List<NivelEsfuerzo> devovlerNe() {
            return neStatic;
        }
        
    }
}