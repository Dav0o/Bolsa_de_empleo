using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RequestObjects
{
    public class Formacion_AcademicaVM
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Tiempo_Empleado { get; set; }

        public string Fecha_Culminacion { get; set; }

        public int CandidatoId { get; set; }

    }
}
