using DataAccess.Models;
using DataAccess.RequestObjects;
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

        public Task<Habilidad> Create(HabilidadVM habilidadVM);

        public Task Update(HabilidadVM habilidadVM);

        public Task Delete(int id);
    }
}
