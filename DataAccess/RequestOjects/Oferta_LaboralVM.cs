using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RequestOjects
{
    public class Oferta_LaboralVM
    {
        public int Id { get; set; }
        
        public string Descripcion_Puesto { get; set; }

        public string Experiencia_Necesaria { get; set; }

        public string Responsabilidades { get; set; }

        public int EmpresaId { get; set; }

       
    }
}
