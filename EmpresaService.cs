using DataAccess.Data;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly MyDbContext _context;

        public EmpresaService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Empresa> Create(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            await _context.SaveChangesAsync();

            return empresa;
        }


        public async Task Delete(int id)
        {
            var empresa = await _context.Empresas.FirstOrDefaultAsync(u => u.Id == id);
            if (empresa != null)
            {
                _context.Empresas.Remove(empresa);
                await _context.SaveChangesAsync();
            }
        }


        public Task<List<Empresa>> GetAll()
        {
            return _context.Empresas.ToListAsync();
        }


        public async Task<Empresa> GetById(int id)
        {
            return await _context.Empresas.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Empresa empresa)
        {
            _context.Empresas.Update(empresa);
            await _context.SaveChangesAsync();
        }

    }
}
