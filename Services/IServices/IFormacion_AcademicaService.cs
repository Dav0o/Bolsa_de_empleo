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
        public Task<List<Formacion_Academica>> GetAll();

        public Task<Formacion_Academica> GetById(int id);

        public Task<Formacion_Academica> Create(Formacion_Academica formacion);

        public Task Update(Formacion_Academica formacion);

        public Task Delete(int id);
    }
}
