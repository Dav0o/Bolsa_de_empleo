using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RequestObjects
{
    public class EmpresaVM
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo_Electronico { get; set; }

        public string Num_Telefono { get; set; }

        public string Pagina_Web { get; set; }

        public string Direccion { get; set; }

    }
}
