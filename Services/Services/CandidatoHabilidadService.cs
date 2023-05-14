using DataAccess.Data;
using DataAccess.ExtensionMethods;
using DataAccess.Models;
using DataAccess.RequestOjects;
using Microsoft.EntityFrameworkCore;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CandidatoHabilidadService : ICandidatoHabilidadService 
    {
        private readonly MyDbContext _context;

        public CandidatoHabilidadService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<CandidatoHabilidad> Create(CandidatoHabilidadVM _candidato)
        {
            CandidatoHabilidad newCandidatoHabilidad;
            newCandidatoHabilidad = _candidato.toCandidatoHabilidad();

            _context.CandidatoHabilidad.Add(newCandidatoHabilidad);
            await _context.SaveChangesAsync();

            return newCandidatoHabilidad;
        }

        public async Task Delete(int id_candidato, int id_habilidad)
        {
            var candidatoHabilidad = await _context.CandidatoHabilidad.FirstOrDefaultAsync(u => u.CandidatoId == id_candidato && u.HabilidadId == id_habilidad);
            if (candidatoHabilidad != null)
            {
                _context.CandidatoHabilidad.Remove(candidatoHabilidad);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<CandidatoHabilidadVM>> GetAll()
        {
            List<CandidatoHabilidad> listaCandidatoHabilidad = await _context.CandidatoHabilidad.ToListAsync();

            List<CandidatoHabilidadVM> listaHabilidadVm = new List<CandidatoHabilidadVM>();

            foreach (CandidatoHabilidad candidatoHabilidad in listaCandidatoHabilidad)
            {
                CandidatoHabilidadVM newCandidatoHabilidadVm = new CandidatoHabilidadVM();
                newCandidatoHabilidadVm.HabilidadId = candidatoHabilidad.HabilidadId;
                newCandidatoHabilidadVm.CandidatoId = candidatoHabilidad.CandidatoId;
                listaHabilidadVm.Add(newCandidatoHabilidadVm);
            }

            return listaHabilidadVm;
        }

        public async Task<CandidatoHabilidad> GetById(int id_candidato, int id_habilidad)
        {
            return await _context.CandidatoHabilidad.FirstOrDefaultAsync(u => u.CandidatoId == id_candidato && u.HabilidadId == id_habilidad);
        }

       
    }
}
