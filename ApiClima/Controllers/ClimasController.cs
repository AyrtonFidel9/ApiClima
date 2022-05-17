using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiClima.Model;
using ApiClima.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ApiClima.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimasController : ControllerBase
    {
        private readonly iClimaRepository _climaRepository;
        public ClimasController(iClimaRepository climaRespository)
        {
            this._climaRepository = climaRespository;
        }

        [HttpGet]
        public IEnumerable<Clima> GetClimas()
        {
            return _climaRepository.Get();
        }

       /* [HttpGet("{id}")]
        public async Task<ActionResult<Clima>> GetClimas(int id)
        {
            return await _climaRepository.Get(id);
        }*/

        [HttpGet("{ciudad}")]
        public async Task<Clima> GetClimas (string ciudad)
        {
            return await _climaRepository.GetForCiudad(ciudad);
        }

        [HttpPost]
        public async Task<ActionResult<Clima>> PostClimas([FromBody] Clima clima)
        {
            var newClima = await _climaRepository.Create(clima);
            return CreatedAtAction(nameof(GetClimas), new { id = newClima.Id }, newClima);
        }

        [HttpPut]
        public async Task<ActionResult> PutClimas(int id, [FromBody] Clima clima)
        {
            if (id != clima.Id)
            {
                return BadRequest();
            }
             
            await _climaRepository.Update(clima);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var climaToDelete = await _climaRepository.Get(id);
            if (climaToDelete == null)
                return NotFound();

            await _climaRepository.Delete(climaToDelete.Id);
            return NoContent();
        }
    }
}
