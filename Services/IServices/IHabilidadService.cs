using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IHabilidadService
    {
        IEnumerable<Habilidad> GetHabilidades();
        Habilidad GetHabilidadById(int id);

        void AddHabilidad(Habilidad habilidad);

        void UpdateHabilidad(int id, Habilidad habilidad);

        void DeleteHabilidad(int id);
    }
}
