using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Formacion_Academica
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Tipo { get; set; }

        //Relaciones

        public int CandidatoId { get; set; }

        public Candidato Candidato { get; set; }
    }
}
