using DataAccess.Models;
using DataAccess.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class toHabilidadExtension
    {
        public static Habilidad toHabilidad(this HabilidadVM obj)
        {
            Habilidad habilidad = new Habilidad();
            habilidad.Id = obj.Id;
            habilidad.Name = obj.Name;

            return habilidad;

        }
    }
}
