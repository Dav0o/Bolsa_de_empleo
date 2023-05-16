using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RequestObjects
{
    public class ExperienciaCandidatoVM
    {

        public int Id { get; set; }
        public string Rol_Desempeñado { get; set; }
        public string Tiempo_Desempeñado { get; set; }
        public int IdCandidato { get; set;  }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
    }
}
