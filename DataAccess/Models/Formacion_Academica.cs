using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Formacion_Academica
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Tiempo_Empleado { get; set; }

        public string Fecha_Culminacion { get; set; }



        //Relaciones

        public int CandidatoId { get; set; }

        public Candidato Candidato { get; set; }
    }
}
