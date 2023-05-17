using DataAccess.Models;
using DataAccess.RequestOjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class toOfertaHabilidadExtension
    {
        public static OfertaHabilidad toOfertaHabilidad(this OfertaHabilidadVM obj)
        {
            OfertaHabilidad newOfertaHabilidad = new OfertaHabilidad();
            newOfertaHabilidad.OfertaId = obj.OfertaId;
            newOfertaHabilidad.HabilidadId = obj.HabilidadId;
            

            return newOfertaHabilidad;
        }
    }
}
