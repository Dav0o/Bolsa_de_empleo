using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Experiencia
    {
        public int Id { get; set; }

        public string Rol_Desempeñado { get; set; }

        public  string Tiempo_Desempeñado { get;set; }

        //Relaciones

        public int CandidatoId { get; set; }

        public Candidato Candidato { get; set; }
    }
}
