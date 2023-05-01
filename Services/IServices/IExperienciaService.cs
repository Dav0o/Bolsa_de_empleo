using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IExperienciaService
    {
        IEnumerable<Experiencia> GetExperiencias();
        Experiencia GetExperienciaById(int id);

        void AddExperiencia(Experiencia experiencia);

        void UpdateExperiencia(int id, Experiencia experiencia);

        void DeleteExperiencia(int id);
    }
}
