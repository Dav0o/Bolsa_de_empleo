using DataAccess.Models;
using DataAccess.RequestObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.IRepository;
using Services.IServices;
using Services.Services;


namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;

        public EmpresasController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        //GET: api/Empresa

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empresa>>> GetAll()
        {

            List<Empresa> listEmpresa = await _empresaService.GetAll();

            return Ok(listEmpresa);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Empresa>> GetById(int id)
        {
            var empresa = await _empresaService.GetById(id);
            if (empresa == null)
            {
                return NotFound();
            }
            return Ok(empresa);
        }

        [HttpPost]

        public async Task<ActionResult<Empresa>> Create(EmpresaVM empresaVM)
        {
            Empresa newEmpresa = await _empresaService.Create(empresaVM);

            return Ok(newEmpresa);
        }

        [HttpPut("{id}")] 

        public async Task<IActionResult> Update(EmpresaVM empresaVM)
        {
            if (empresaVM == null)
            {
                return BadRequest();
            }
            await _empresaService.Update(empresaVM);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var empresa = await _empresaService.GetById(id);
            if (empresa == null)
            {
                return NotFound();
            }
            await _empresaService.Delete(id);
            return NoContent();
        }
    }
}

