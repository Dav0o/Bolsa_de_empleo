using DataAccess.Models;
using DataAccess.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class toEmpresaExtension
    {
        public static Empresa toEmpresa(this EmpresaVM obj)
        {
            Empresa empresa = new Empresa();

            
            empresa.Id = obj.Id;

            empresa.Nombre = obj.Nombre;

            empresa.Correo_Electronico = obj.Correo_Electronico;

            empresa.Num_Telefono = obj.Num_Telefono;

            empresa.Pagina_Web = obj.Pagina_Web;

            empresa.Direccion = obj.Direccion;



            return empresa;
        }
    }
}