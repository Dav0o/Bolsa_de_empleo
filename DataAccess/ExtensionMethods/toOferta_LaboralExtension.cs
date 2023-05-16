using DataAccess.Models;
using DataAccess.RequestOjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class toOferta_LaboralExtension
    {
        public static Oferta_Laboral toOferta_Laboral(this Oferta_LaboralVM obj)
        {
            Oferta_Laboral oferta_Laboral = new Oferta_Laboral();

            oferta_Laboral.Id = obj.Id;
            oferta_Laboral.Descripcion_Puesto = obj.Descripcion_Puesto;
            oferta_Laboral.Experiencia_Necesaria = obj.Experiencia_Necesaria;
            oferta_Laboral.Responsabilidades = obj.Responsabilidades;


            return oferta_Laboral;
        }
    }
}
