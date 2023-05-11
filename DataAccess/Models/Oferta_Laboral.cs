using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Oferta_Laboral
    {
        public int Id { get; set; }

        public string Descripcion_Puesto { get; set; }   
        
        public string Experiencia_Necesaria { get; set; }

        public string Responsabilidades { get; set; }


        //Relaciones
        public int EmpresaId { get; set; }

        public Empresa Empresa { get; set; }

        public List<OfertaHabilidad> OfertaHabilidades { get; set; }
        public List<CandidatoOferta> CandidatoOfertas { get; set; }



    }
}
