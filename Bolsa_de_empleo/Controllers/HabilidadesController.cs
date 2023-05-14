using Bolsa_de_empleo.RequestObjects;
using DataAccess.Models;
using DataAccess.RequestObjects;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadesController : ControllerBase
    {
        private readonly IHabilidadService _habilidadService;

        public HabilidadesController(IHabilidadService habilidadService)
        {
            _habilidadService = habilidadService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<HabilidadVM>>> GetHabilidad()
        {
            List<Habilidad> listHabilidad = await _habilidadService.GetAll();

            return Ok(listHabilidad);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Habilidad>> GetHabilidad(int id)
        {
            var habilidad = await _habilidadService.GetById(id);
            if (habilidad == null)
            {
                return NotFound();
            }
            return Ok(habilidad);

        }


        [HttpPost]
        public async Task<ActionResult<Habilidad>> PostHabilidad(HabilidadVM habilidadVM)
        {
            Habilidad newHabilidad = await _habilidadService.Create(habilidadVM);

            return Ok(newHabilidad);

        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update(HabilidadVM habilidadVM)
        {

            if (habilidadVM == null)
            {
                return BadRequest();
            }
            await _habilidadService.Update(habilidadVM);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var habilidad = await _habilidadService.GetById(id);
            if (habilidad == null)
            {
                return NotFound();
            }
            await _habilidadService.Delete(id);
            return NoContent();
        }

    }
}
