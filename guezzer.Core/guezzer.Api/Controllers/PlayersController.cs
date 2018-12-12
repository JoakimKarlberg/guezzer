using System;
using System.Threading.Tasks;
using guezzer.Api.Helpers;
using guezzer.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace guezzer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository _repository;

        public PlayersController(IPlayerRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Players/
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAll();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/Players/{name}
        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var result = await _repository.Get(name);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //PUT: api/Players/{playerDto-object}
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePlayerDto playerDto)
        {
            if(playerDto == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var result = await _repository.Update(playerDto);

            return NoContent();
        }
    }
}
