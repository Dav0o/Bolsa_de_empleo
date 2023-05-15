using Bolsa_de_empleo.RequestObjects;
using DataAccess.Data;
using DataAccess.ExtensionMethods;
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

        public async Task<Candidato> Create(CandidatoVM candidatoVM)
        {
            Candidato newCandidato = new Candidato();
            newCandidato = candidatoVM.toCandidato();

            _context.Candidatos.Add(newCandidato);
            await _context.SaveChangesAsync();

            return newCandidato;
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

        public async Task Update(CandidatoVM candidatoVM)
        {
            Candidato newCandidato = await _context.Candidatos.FindAsync(candidatoVM.Id);

           
                newCandidato.Nombre = candidatoVM.Nombre;
                newCandidato.Apellido1 = candidatoVM.Apellido1;
                newCandidato.Apellido2 = candidatoVM.Apellido2;
                newCandidato.Telefono = candidatoVM.Telefono;
                newCandidato.Correo_Electronico = candidatoVM.Correo_Electronico;
                newCandidato.Direccion = candidatoVM.Direccion;
                newCandidato.Descripcion = candidatoVM.Descripcion;

                _context.Entry(newCandidato).State = EntityState.Modified;
                await _context.SaveChangesAsync();// aquí puedes acceder a la variable newCandidato sin problemas
         

            
        }
    }
}
