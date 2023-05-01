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
    public class Formacion_AcademicaService : IFormacion_AcademicaService
    {
        private readonly MyDbContext _context;

        public Formacion_AcademicaService(MyDbContext context)
        {
            _context = context;
        }

        public void AddFormacion(Formacion_Academica formacion)
        {
            _context.Formaciones.Add(formacion);
            _context.SaveChanges();
        }

        public void DeleteFormacion(int id)
        {
            var formacion = _context.Formaciones.FirstOrDefault(c => c.Id == id);

            if (formacion != null)
            {
                _context.Formaciones.Remove(formacion);
                _context.SaveChanges();
            }
        }

        public Formacion_Academica GetFormacionById(int id)
        {
            return _context.Formaciones.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Formacion_Academica> GetFormaciones()
        {
            return _context.Formaciones.ToList();
        }

        public void UpdateFormacion(int id, Formacion_Academica formacion)
        {
            _context.Formaciones.Update(formacion);
            _context.SaveChanges();
        }
    }
}
