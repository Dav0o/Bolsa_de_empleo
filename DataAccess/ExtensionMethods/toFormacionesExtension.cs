using DataAccess.Models;
using DataAccess.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    
        public static class toFormacionesExtension
        {
            public static Formacion_Academica toFormacion_Academica(this Formacion_AcademicaVM obj)
            {
                Formacion_Academica newFormaciones = new Formacion_Academica();
                newFormaciones.Titulo = obj.Titulo;
                newFormaciones.Tiempo_Empleado = obj.Tiempo_Empleado;
                newFormaciones.Fecha_Culminacion = obj.Fecha_Culminacion;
                newFormaciones.CandidatoId = obj.CandidatoId;
               

                return newFormaciones;
            }
        }
}