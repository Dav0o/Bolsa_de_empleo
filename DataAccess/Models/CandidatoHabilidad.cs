using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CandidatoHabilidad
    {
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public int HabilidadId { get; set; }
        public Habilidad Habilidad { get; set; }
    }
}
