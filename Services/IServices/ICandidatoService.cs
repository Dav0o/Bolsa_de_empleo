using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IRepository
{
    public interface ICandidatoService
    {

        public Task<List<Candidato>> GetAll();

        public Task<Candidato> GetById(int id);

        public Task<Candidato> Create(Candidato candidato);

        public Task Update(Candidato candidato);

        public Task Delete(int id);


    }
}
