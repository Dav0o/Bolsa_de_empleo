using DataAccess.Models;
using DataAccess.RequestOjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoHabilidadesController : ControllerBase
    {
        private readonly ICandidatoHabilidadService _candidatohabilidadService;

        public CandidatoHabilidadesController(ICandidatoHabilidadService candidatohabilidadService)
        {
            _candidatohabilidadService = candidatohabilidadService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidatoHabilidadVM>>> GetCandidatoHabilidad()
        {
            List<CandidatoHabilidadVM> listCandidatoHabilidadVm = await _candidatohabilidadService.GetAll();

            if (listCandidatoHabilidadVm == null)
            {
                return NotFound();
            }
            return Ok(listCandidatoHabilidadVm);
        }

        [HttpPost]
        public async Task<ActionResult<CandidatoHabilidad>> PostCandidatoHabilidad(CandidatoHabilidadVM candidatohabilidadRequest)
        {
            if (candidatohabilidadRequest == null)
            {
                return BadRequest();
            }

            CandidatoHabilidad newCandidatoHabilidad = await _candidatohabilidadService.Create(candidatohabilidadRequest);

            return CreatedAtAction("GetCandidatoHabilidad", new { id = newCandidatoHabilidad.CandidatoId }, newCandidatoHabilidad);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCandidatoHabilidad(int id_candidato, int id_habilidad)
        {
            var candidatohabilidad = await _candidatohabilidadService.GetById(id_candidato, id_habilidad);
            if (candidatohabilidad == null)
            {
                return NotFound();
            }

            await _candidatohabilidadService.Delete(id_candidato, id_habilidad);
            return NoContent();
        }
    }
}
