﻿using DataAccess.Models;
using DataAccess.RequestOjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface ICandidatoOfertaService
    {
        public Task<List<CandidatoOfertaVM>> GetAll();

        public Task<CandidatoOferta> GetById(int id_candidato, int id_oferta);

        public Task<CandidatoOferta> Create(CandidatoOfertaVM candidato);

        public Task Delete(int id_candidato, int id_oferta);
    }
}
