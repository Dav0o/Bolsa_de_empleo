using DataAccess.Data;
using DataAccess.ExtensionMethods;
using DataAccess.Models;
using DataAccess.RequestOjects;
using Microsoft.EntityFrameworkCore;
using Services.IRepository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Oferta_LaboralService : IOferta_LaboralService
    {
        private readonly MyDbContext _context;

        public Oferta_LaboralService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Oferta_Laboral> Create(Oferta_LaboralVM oferta_LaboralVM)
        {
            Oferta_Laboral newoferta_Laboral = new Oferta_Laboral();
            newoferta_Laboral = oferta_LaboralVM.toOferta_Laboral();

            _context.Ofertas_Laborales.Add(newoferta_Laboral);
            await _context.SaveChangesAsync();

            return newoferta_Laboral;
        }

        public async Task Delete(int id)
        {
            var oferta_laboral = await _context.Ofertas_Laborales.FirstOrDefaultAsync(u => u.Id == id);
            if (oferta_laboral != null)
            {
                _context.Ofertas_Laborales.Remove(oferta_laboral);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Oferta_Laboral>> GetAll()
        {
            var ofertas = await _context.Ofertas_Laborales.ToListAsync();

            foreach (var oferta in ofertas)
            {
                await _context.Entry(oferta)
                    .Collection(c => c.OfertaHabilidades)
                    .LoadAsync();

                await _context.Entry(oferta)
                   .Collection(c => c.CandidatoOfertas)
                   .LoadAsync();


            }
            return ofertas;
        }

        public async Task<Oferta_Laboral> GetById(int id)
        {
            return await _context.Ofertas_Laborales.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Oferta_LaboralVM oferta_LaboralVM)
        {
            Oferta_Laboral newOferta_Laboral;

           newOferta_Laboral = oferta_LaboralVM.toOferta_Laboral();

            _context.Entry(newOferta_Laboral).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
