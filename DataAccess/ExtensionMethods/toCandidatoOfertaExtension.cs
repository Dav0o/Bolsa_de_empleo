using DataAccess.Models;
using DataAccess.RequestOjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class toCandidatoOfertaExtension
    {
        public static CandidatoOferta toCandidatoOferta(this CandidatoOfertaVM obj)
        {
            CandidatoOferta newCandidatoOferta = new CandidatoOferta();
            newCandidatoOferta.CandidatoId = obj.CandidatoId;
            newCandidatoOferta.OfertaId = obj.OfertaId;

            return newCandidatoOferta;
        }
    }
}
