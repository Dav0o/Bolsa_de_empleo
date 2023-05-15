using Bolsa_de_empleo.RequestObjects;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    public static class toCandidatoExtension
    {
        public static Candidato toCandidato(this CandidatoVM obj)
        {
            Candidato candidato = new Candidato();

            candidato.Id = obj.Id; //Si se usa SQL server, no hay que llenar id en el swagger
            candidato.Nombre = obj.Nombre;
            candidato.Apellido1 = obj.Apellido1;
            candidato.Apellido2 = obj.Apellido2;
            candidato.Telefono = obj.Telefono;
            candidato.Correo_Electronico = obj.Correo_Electronico;
            candidato.Direccion = obj.Direccion;
            candidato.Descripcion = obj.Descripcion;

            return candidato;
        }
    }
}
