using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Candidato
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public int Telefono { get; set; }

        public string Correo_Electronico { get; set; }

        public string Direccion { get; set; }

        public string Descripcion { get; set; }

        //Relaciones
        
        public List<Formacion_Academica> Formaciones { get; set; }
       
        public List<Experiencia> Experiencias { get; set; }

        public List<Habilidad> Habilidades { get; set; }
    }
}


