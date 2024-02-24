using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webpractica.Models;
using Microsoft.EntityFrameworkCore;

namespace webpractica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly EquiposContext _equiposContext;

        public equiposController(EquiposContext equiposContext)
        {
            _equiposContext = equiposContext;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<Equipo> listadoequipo = (from e in _equiposContext.Equipos select e).ToList();

            if (listadoequipo.Count() == 0) { 
            return NotFound();
            }
            return Ok(listadoequipo);
        }
    }
}
