using DataAccess.Data;
using DataAccess.Models;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ExperienciaService : IExperienciaService
    {
        private readonly MyDbContext _context;

        public ExperienciaService(MyDbContext context)
        {
            _context = context;
        }
        public void AddExperiencia(Experiencia experiencia)
        {
            _context.Experiencias.Add(experiencia);
            _context.SaveChanges();
        }

        public void DeleteExperiencia(int id)
        {
            var experiencia = _context.Experiencias.FirstOrDefault(x => x.Id == id);

            if (experiencia != null)
            {
                _context.Experiencias.Remove(experiencia);
                _context.SaveChanges();
            }
        }

        public Experiencia GetExperienciaById(int id)
        {
            return _context.Experiencias.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Experiencia> GetExperiencias()
        {
            return _context.Experiencias.ToList();
        }

        public void UpdateExperiencia(int id, Experiencia experiencia)
        {
            _context.Experiencias.Update(experiencia);
            _context.SaveChanges();
        }
    }
}
