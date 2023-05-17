using DataAccess.Models;
using DataAccess.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IFormacion_AcademicaService
    {
        public Task<List<Formacion_Academica>> GetAll();

        public Task<FormacionCandidatoVM> GetById(int id);

        public Task<Formacion_Academica> Create(Formacion_AcademicaVM formacionVM);

        public Task Update(Formacion_AcademicaVM formacionVM);

        public Task Delete(int id);
    }
}
