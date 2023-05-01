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

        public void AddCandidato(Candidato candidato)
        {
            _context.Candidatos.Add(candidato);
            _context.SaveChanges();
        }

        public void DeleteCandidato(int id)
        {
            var candidato = _context.Candidatos.FirstOrDefault(c => c.Id == id);

            if (candidato != null)
            {
                _context.Candidatos.Remove(candidato);
                _context.SaveChanges();
            }
        }

        public Candidato GetCandidatoById(int id)
        {
            return _context.Candidatos.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Candidato> GetCandidatos()
        {
            return _context.Candidatos.ToList();
        }

        public void UpdateCandidato(int id, Candidato candidato)
        {
            _context.Candidatos.Update(candidato);
            _context.SaveChanges();
        }
    }
}
