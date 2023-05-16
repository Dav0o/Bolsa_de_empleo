using DataAccess.Models;
using DataAccess.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IRepository;
using Services.IServices;

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciasController : ControllerBase
    {
       
            private readonly IExperienciaService _experienciaService;

            public ExperienciasController(IExperienciaService experienciaService)
            {
                _experienciaService = experienciaService;
            }

            //GET: api/Experiencia

            [HttpGet]
            public async Task<ActionResult<IEnumerable<Experiencia>>> GetAll()
            {

                List<Experiencia> listExperiencia = await _experienciaService.GetAll();

                return Ok(listExperiencia);
            }

            [HttpGet("{id}")]

            public async Task<ActionResult<Experiencia>> GetById(int id)
            {
                var experiencia = await _experienciaService.GetById(id);
                if (experiencia == null)
                {
                    return NotFound();
                }
                return Ok(experiencia);
            }

            [HttpPost]

            public async Task<ActionResult<Experiencia>> Create(ExperienciaVM experienciaVM)
            {
                Experiencia newExperiencia = await _experienciaService.Create(experienciaVM);

                return Ok(newExperiencia);
            }

            [HttpPut("{id}")]

            public async Task<IActionResult> Update(ExperienciaVM experienciaVM)
            {
                if (experienciaVM == null)
                {
                    return BadRequest();
                }
                await _experienciaService.Update(experienciaVM);
                return NoContent();
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                var experiencia= await _experienciaService.GetById(id);
                if (experiencia == null)
                {
                    return NotFound();
                }
                await _experienciaService.Delete(id);
                return NoContent();
            }
        }
    }



