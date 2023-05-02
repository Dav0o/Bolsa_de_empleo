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
        public Task<List<Habilidad>> GetAll();

        public Task<Habilidad> GetById(int id);

        public Task<Habilidad> Create(Habilidad habilidad);

        public Task Update(Habilidad habilidad);

        public Task Delete(int id);
    }
}
