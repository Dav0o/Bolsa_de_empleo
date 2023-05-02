using DataAccess.Data;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly MyDbContext _context;

        public CandidatoService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Candidato> Create(Candidato candidato)
        {
            _context.Candidatos.Add(candidato);
            await _context.SaveChangesAsync();

            return candidato;
        }

        public async Task Delete(int id)
        {
            var candidato = await _context.Candidatos.FirstOrDefaultAsync(u => u.Id == id);
            if (candidato != null) 
            {
                _context.Candidatos.Remove(candidato);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Candidato>> GetAll()
        {
            return _context.Candidatos.ToListAsync();
        }

        public async Task<Candidato> GetById(int id)
        {
            return await _context.Candidatos.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Candidato candidato)
        {
            _context.Candidatos.Update(candidato);
            await _context.SaveChangesAsync();
        }
    }
}
