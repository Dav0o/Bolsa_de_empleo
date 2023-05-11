using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CandidatoOferta
    {
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public int OfertaId { get; set; }
        public Oferta_Laboral Oferta { get; set; }
    }
}
