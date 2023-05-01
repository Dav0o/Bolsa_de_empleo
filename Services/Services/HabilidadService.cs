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
    public class HabilidadService : IHabilidadService
    {
        private readonly MyDbContext _context;

        public HabilidadService(MyDbContext context)
        {
            _context = context;
        }
        public void AddHabilidad(Habilidad habilidad)
        {
            _context.Habilidades.Add(habilidad);
            _context.SaveChanges();
        }

        public void DeleteHabilidad(int id)
        {
            var habilidad = _context.Habilidades.FirstOrDefault(h => h.Id == id);

            if(habilidad != null)
            {
                _context.Habilidades.Remove(habilidad);
                _context.SaveChanges();
            }
        }

        public Habilidad GetHabilidadById(int id)
        {
            return _context.Habilidades.FirstOrDefault(h => h.Id == id);
        }

        public IEnumerable<Habilidad> GetHabilidades()
        {
            return _context.Habilidades.ToList();
        }

        public void UpdateHabilidad(int id, Habilidad habilidad)
        {
            _context.Habilidades.Update(habilidad);
            _context.SaveChanges();
        }
    }
}
