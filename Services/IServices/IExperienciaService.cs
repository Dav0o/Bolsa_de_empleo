using DataAccess.Models;
using DataAccess.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IExperienciaService
    {
        public Task<List<Experiencia>> GetAll();

        public Task<ExperienciaCandidatoVM> GetById(int id);

        public Task<Experiencia> Create(ExperienciaVM experienciaVM);

        public Task Update(ExperienciaVM experienciaVM);

        public Task Delete(int id);
    }
}
