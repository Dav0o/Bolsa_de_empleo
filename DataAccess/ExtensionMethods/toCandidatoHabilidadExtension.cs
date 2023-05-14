using DataAccess.Models;
using DataAccess.RequestOjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class toCandidatoHabilidadExtension
    {
        public static CandidatoHabilidad toCandidatoHabilidad(this CandidatoHabilidadVM obj)
        {
            CandidatoHabilidad newCandidatoHabilidad = new CandidatoHabilidad();
            newCandidatoHabilidad.CandidatoId = obj.CandidatoId;
            newCandidatoHabilidad.HabilidadId = obj.HabilidadId;

            return newCandidatoHabilidad;
        }
    }
}
