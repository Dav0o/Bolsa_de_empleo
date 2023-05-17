using DataAccess.Data;
using DataAccess.Models;
using DataAccess.RequestObjects;
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

        public async Task<Empresa> Create(EmpresaVM empresaVM)
        {
            Empresa newEmpresa = new Empresa();
            newEmpresa.Id = empresaVM.Id;
            newEmpresa.Nombre = empresaVM.Nombre;
            newEmpresa.Correo_Electronico = empresaVM.Correo_Electronico;
            newEmpresa.Num_Telefono = empresaVM.Num_Telefono;
            newEmpresa.Pagina_Web = empresaVM.Pagina_Web;
            newEmpresa.Direccion = empresaVM.Direccion;


            _context.Empresas.Add(newEmpresa);
            await _context.SaveChangesAsync();

            return newEmpresa;
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


        public async Task<List<Empresa>> GetAll()
        {
            var empresas = await _context.Empresas.ToListAsync();

            foreach (var empresa in empresas)
            {
                await _context.Entry(empresa)
                    .Collection(c => c.Ofertas)
                    .LoadAsync();

         
            }
            return empresas;
        }


        public async Task<Empresa> GetById(int id)
        {
            return await _context.Empresas.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(EmpresaVM empresaVM)
        {

            Empresa newEmpresa = new Empresa();
            newEmpresa.Id = empresaVM.Id;
            newEmpresa.Nombre = empresaVM.Nombre;
            newEmpresa.Correo_Electronico = empresaVM.Correo_Electronico;
            newEmpresa.Num_Telefono = empresaVM.Num_Telefono;
            newEmpresa.Pagina_Web = empresaVM.Pagina_Web;
            newEmpresa.Direccion = empresaVM.Direccion;


            _context.Entry(newEmpresa).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }


    }
}
