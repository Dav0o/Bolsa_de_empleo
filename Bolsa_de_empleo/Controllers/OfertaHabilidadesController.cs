using DataAccess.Models;
using DataAccess.RequestOjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaHabilidadesController : ControllerBase
    {
        private readonly IOfertaHabilidadService _ofertahabilidadService;

        public OfertaHabilidadesController(IOfertaHabilidadService ofertahabilidadService)
        {
            _ofertahabilidadService = ofertahabilidadService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfertaHabilidad>>> GetOfertaHabilidad()
        {
            List<OfertaHabilidad> listOfertaHabilidadVM = await _ofertahabilidadService.GetAll();

            if (listOfertaHabilidadVM == null)
            {
                return NotFound();
            }
            return Ok(listOfertaHabilidadVM);
        }

        [HttpPost]
        public async Task<ActionResult<OfertaHabilidad>> PostOfertaHabilidad(OfertaHabilidadVM ofertahabilidadRequest)
        {
            if (ofertahabilidadRequest == null)
            {
                return BadRequest();
            }

            OfertaHabilidad newOfertaHabilidad = await _ofertahabilidadService.Create(ofertahabilidadRequest);

            return CreatedAtAction("GetOfertaHabilidad", new { id = newOfertaHabilidad.OfertaId }, newOfertaHabilidad);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOfertaHabilidad(int id_oferta, int id_habilidad)
        {
            var ofertahabilidad = await _ofertahabilidadService.GetById(id_oferta,id_habilidad);
            if (ofertahabilidad == null)
            {
                return NotFound();
            }

            await _ofertahabilidadService.Delete(id_oferta, id_habilidad);
            return NoContent();
        }
    }
}
