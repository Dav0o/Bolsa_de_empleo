using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RequestObjects
{
    public class FormacionCandidatoVM
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Tiempo_Empleado { get; set; }
        public string Fecha_Culminacion { get; set; }
        public int IdCandidato { get; set; }
        public string NombreCandidato { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
    }
}
