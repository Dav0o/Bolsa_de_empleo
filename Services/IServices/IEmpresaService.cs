using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IEmpresaService
    {

        public Task<List<Empresa>> GetAll();

        public Task<Empresa> GetById(int id);

        public Task<Empresa> Create(Empresa empresa);

        public Task Update(Empresa empresa);

        public Task Delete(int id);


    }
}
