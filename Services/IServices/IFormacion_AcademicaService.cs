using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IFormacion_AcademicaService
    {
        IEnumerable<Formacion_Academica> GetFormaciones();
        Formacion_Academica GetFormacionById(int id);

        void AddFormacion(Formacion_Academica formacion);

        void UpdateFormacion(int id, Formacion_Academica formacion);

        void DeleteFormacion(int id);
    }
}
