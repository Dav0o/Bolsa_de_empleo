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
    public class OfertaHabilidadService : IOfertaHabilidadService
    {
        private readonly MyDbContext _context;

        public OfertaHabilidadService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<OfertaHabilidad> Create(OfertaHabilidadVM _oferta)
        {
            OfertaHabilidad newOfertaHabilidad;
            newOfertaHabilidad = _oferta.toOfertaHabilidad();

            _context.OfertaHabilidad.Add(newOfertaHabilidad);
            await _context.SaveChangesAsync();

            return newOfertaHabilidad;
        }
        public async Task Delete(int id_oferta, int id_habilidad)
        {
            var ofertaHabilidad = await _context.OfertaHabilidad.FirstOrDefaultAsync(u => u.OfertaId == id_oferta && u.HabilidadId == id_habilidad);
            if (ofertaHabilidad != null)
            {
                _context.OfertaHabilidad.Remove(ofertaHabilidad);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<OfertaHabilidad>> GetAll()
        {
            var ofertas = await _context.OfertaHabilidad.ToListAsync();
            return ofertas;
        }

        
        public async Task<OfertaHabilidad> GetById(int id_oferta, int id_habilidad)
        {
            return await _context.OfertaHabilidad.FirstOrDefaultAsync(u => u.OfertaId == id_oferta && u.HabilidadId == id_habilidad);
        }
    }
}
