using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RequestObjects
{
    public class ExperienciaVM
    {
       
        public int Id { get; set; }
        public string Rol_Desempeñado { get; set; }

        public string Tiempo_Desempeñado { get; set; }

        public int CandidatoId { get; set; }

        

    }
}