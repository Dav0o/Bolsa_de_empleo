using DataAccess.Models;
using DataAccess.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IRepository;
using Services.IServices;
using Services.Services;

namespace Bolsa_de_empleo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Formaciones_AcademicasController : ControllerBase
    {
            private readonly IFormacion_AcademicaService _formacion_AcademicaService;

            public Formaciones_AcademicasController(IFormacion_AcademicaService formacion_AcademicaService)
            {
            _formacion_AcademicaService = formacion_AcademicaService;
            }

        //GET: api/Formacion_Academica

        [HttpGet]
            public async Task<ActionResult<IEnumerable<Formacion_Academica>>> GetAll()
            {

                List<Formacion_Academica> listFormacion_Academica = await _formacion_AcademicaService.GetAll();

                return Ok(listFormacion_Academica);
            }

            [HttpGet("{id}")]

            public async Task<ActionResult<Formacion_Academica>> GetById(int id)
            {
                var formacion = await _formacion_AcademicaService.GetById(id);
                if (formacion == null)
                {
                    return NotFound();
                }
                return Ok(formacion);
            }

            [HttpPost]

            public async Task<ActionResult<Formacion_Academica>> Create(Formacion_AcademicaVM formacionVM)
            {
            Formacion_Academica newFormacion_Academica = await _formacion_AcademicaService.Create(formacionVM);

                return Ok(newFormacion_Academica);
            }

            [HttpPut("{id}")] 

            public async Task<IActionResult> Update(Formacion_AcademicaVM formacionVM)
            {
                if (formacionVM == null)
                {
                    return BadRequest();
                }
                await _formacion_AcademicaService.Update(formacionVM);
                return NoContent();
            }
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                var formacion = await _formacion_AcademicaService.GetById(id);
                if (formacion == null)
                {
                    return NotFound();
                }
                await _formacion_AcademicaService.Delete(id);
                return NoContent();
            }
        }
    }


