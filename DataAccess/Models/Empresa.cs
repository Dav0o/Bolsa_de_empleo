namespace DataAccess.Models
{
    public class Empresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo_Electronico { get; set; }

        public string Num_Telefono { get; set;}

        public string Pagina_Web { get; set; }

        public string Direccion { get; set; }



        //Relaciones

        public List<Oferta_Laboral> Ofertas { get; set; }


    }
}