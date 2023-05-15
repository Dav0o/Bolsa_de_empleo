using Bolsa_de_empleo.RequestObjects;
using DataAccess.Models;
using DataAccess.RequestOjects;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Oferta_LaboralController : Controller
    {
        private readonly IOferta_LaboralService _oferta_LaboralService;

        public Oferta_LaboralController(IOferta_LaboralService oferta_LaboralService)
        {
            _oferta_LaboralService = oferta_LaboralService;
        }

        //Get : api/Oferta_Laborales

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Oferta_Laboral>>> GetAll()
        {
            List<Oferta_Laboral> listOferta_Laboral = await _oferta_LaboralService.GetAll();
            return Ok(listOferta_Laboral);
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<Oferta_Laboral>> GetById(int id)
        {
            var ofertaLaboral = await _oferta_LaboralService.GetById(id);
            if (ofertaLaboral == null)
            {
                return NotFound();
            }
            return Ok(ofertaLaboral);
        }

        [HttpPost]

        public async Task<ActionResult<Oferta_Laboral>> Create(Oferta_LaboralVM oferta_LaboralVM)
        {
            Oferta_Laboral newOferta_Laboral = await _oferta_LaboralService.Create(oferta_LaboralVM);

            return Ok(newOferta_Laboral);
        }

        [HttpPut("{id}")] 

        public async Task<IActionResult> Update(Oferta_LaboralVM oferta_LaboralVM)
        {

            if (oferta_LaboralVM == null)
            {
                return BadRequest();
            }
            await _oferta_LaboralService.Update(oferta_LaboralVM);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var oferta_Laboral = await _oferta_LaboralService.GetById(id);
            if (oferta_Laboral == null)
            {
                return NotFound();
            }
            await _oferta_LaboralService.Delete(id);
            return NoContent();
        }

    }
}
