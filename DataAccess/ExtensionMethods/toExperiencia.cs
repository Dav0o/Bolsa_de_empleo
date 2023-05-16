using DataAccess.Models;
using DataAccess.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ExtensionMethods
{
    
        public static class toEperienciaExtension
        {
            public static Experiencia toExperiencia(this ExperienciaVM obj)
            {
                Experiencia experiencia = new Experiencia();

                experiencia.Rol_Desempeñado = obj.Rol_Desempeñado;
                experiencia.Tiempo_Desempeñado = obj.Tiempo_Desempeñado;
                experiencia.CandidatoId = obj.CandidatoId;


                return experiencia;
            }
        }
    }