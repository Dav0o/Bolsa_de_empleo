using DataAccess.Models;
using DataAccess.RequestOjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoOfertasController : ControllerBase
    {
        private readonly ICandidatoOfertaService _candidatoofertaService;

        public CandidatoOfertasController(ICandidatoOfertaService candidatoofertaService)
        {
            _candidatoofertaService = candidatoofertaService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CandidatoOfertaVM>>> GetCandidatoOferta()
        {
            List<CandidatoOfertaVM> listCandidatoOfertaVm = await _candidatoofertaService.GetAll();

            if (listCandidatoOfertaVm == null)
            {
                return NotFound();
            }
            return Ok(listCandidatoOfertaVm);
        }

        [HttpPost]
        public async Task<ActionResult<CandidatoOferta>> PostCandidatoOferta(CandidatoOfertaVM candidatoofertaRequest)
        {
            if (candidatoofertaRequest == null)
            {
                return BadRequest();
            }

            CandidatoOferta newCandidatoOferta = await _candidatoofertaService.Create(candidatoofertaRequest);

            return CreatedAtAction("GetCandidatoOferta", new { id = newCandidatoOferta.CandidatoId }, newCandidatoOferta);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCandidatoOferta(int id_candidato, int id_oferta)
        {
            var candidatooferta = await _candidatoofertaService.GetById(id_candidato,id_oferta);
            if (candidatooferta == null)
            {
                return NotFound();
            }

            await _candidatoofertaService.Delete(id_candidato, id_oferta);
            return NoContent();
        }
    }
}
