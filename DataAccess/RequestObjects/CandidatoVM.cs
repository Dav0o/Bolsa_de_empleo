using DataAccess.Models;

namespace Bolsa_de_empleo.RequestObjects
{
    public class CandidatoVM
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public int Telefono { get; set; }

        public string Correo_Electronico { get; set; }

        public string Direccion { get; set; }

        public string Descripcion { get; set; }

    }
}
