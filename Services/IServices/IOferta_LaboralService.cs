using DataAccess.Models;
using DataAccess.RequestOjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IOferta_LaboralService
    {

        public Task<List<Oferta_Laboral>> GetAll();

        public Task<Oferta_Laboral> GetById(int id);

        public Task<Oferta_Laboral> Create(Oferta_LaboralVM oferta_LaboralVM);

        public Task Update(Oferta_LaboralVM oferta_LaboralVM);

        public Task Delete(int id);


    }
}
