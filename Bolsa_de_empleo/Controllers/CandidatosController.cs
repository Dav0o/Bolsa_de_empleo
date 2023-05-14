using Bolsa_de_empleo.RequestObjects;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.IRepository;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatosController : ControllerBase
    {
        private readonly ICandidatoService _candidatoService;

        public CandidatosController(ICandidatoService candidatoService)
        {
            _candidatoService = candidatoService;
        }

        //GET: api/Candidatos 

       [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidato>>> GetAll()
        {

            List<Candidato> listCandidato = await _candidatoService.GetAll();

            return Ok(listCandidato);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Candidato>> GetById(int id)
        {
            var candidato = await _candidatoService.GetById(id);
            if (candidato == null)
            {
                return NotFound();
            }
            return Ok(candidato);
        }

        [HttpPost]

        public async Task<ActionResult<Candidato>> Create(CandidatoVM candidatoVM)
        {
            Candidato newCandidato = await _candidatoService.Create(candidatoVM);

            return Ok(newCandidato);
        }

        [HttpPut("{id}")] //pasarlo a que reciba un argumento "id"

        public async Task<IActionResult> Update(CandidatoVM candidatoVM)
        {

            if (candidatoVM == null)
            {
                return BadRequest();
            }
            await _candidatoService.Update(candidatoVM);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var candidato = await _candidatoService.GetById(id);
            if (candidato == null)
            {
                return NotFound();
            }
            await _candidatoService.Delete(id);
            return NoContent();
        }
    }
}
