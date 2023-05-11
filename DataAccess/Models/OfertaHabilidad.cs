using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OfertaHabilidad
    {
        public int OfertaId { get; set; }
        public Oferta_Laboral Oferta { get; set; }
        public int HabilidadId { get; set; }
        public Habilidad Habilidad { get; set; }
    }
}
