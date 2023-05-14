using DataAccess.Data;
using DataAccess.Models;
using DataAccess.RequestOjects;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.ExtensionMethods;
using Microsoft.EntityFrameworkCore;

namespace Services.Services
{
    public class CandidatoOfertaService : ICandidatoOfertaService
    {
        private readonly MyDbContext _context;

        public CandidatoOfertaService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<CandidatoOferta> Create(CandidatoOfertaVM _candidato)
        {
            CandidatoOferta newCandidatoOferta;
            newCandidatoOferta = _candidato.toCandidatoOferta();

            _context.CandidatoOferta.Add(newCandidatoOferta);
            await _context.SaveChangesAsync();

            return newCandidatoOferta;
        }

        public async Task Delete(int id_candidato, int id_oferta)
        {
            var candidatoOferta = await _context.CandidatoOferta.FirstOrDefaultAsync(u => u.CandidatoId == id_candidato && u.OfertaId == id_oferta);
            if (candidatoOferta != null)
            {
                _context.CandidatoOferta.Remove(candidatoOferta);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<CandidatoOfertaVM>> GetAll()
        {
            List<CandidatoOferta> listaCandidatoOferta = await _context.CandidatoOferta.ToListAsync();

            List<CandidatoOfertaVM> listaOfertaVm = new List<CandidatoOfertaVM>();

            foreach (CandidatoOferta candidatoOferta in listaCandidatoOferta)
            {
                CandidatoOfertaVM newCandidatoOfertaVm = new CandidatoOfertaVM();
                newCandidatoOfertaVm.CandidatoId = candidatoOferta.CandidatoId;
                newCandidatoOfertaVm.OfertaId = candidatoOferta.OfertaId;
                listaOfertaVm .Add(newCandidatoOfertaVm);

            }

            return listaOfertaVm;
        }

        public async Task<CandidatoOferta> GetById(int id_candidato, int id_oferta)
        {
            return await _context.CandidatoOferta.FirstOrDefaultAsync(u => u.CandidatoId == id_candidato && u.OfertaId == id_oferta);
        }
    }
}
