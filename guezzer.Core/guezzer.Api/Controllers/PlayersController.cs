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
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAll();

            return Ok(result);
        }

        // GET: api/Players/348yt9fhoin34iugbvnwekf
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }

        //PUT: api/Players/{playerDto-object}
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PlayerDto playerDto)
        {
            var result = await _repository.Update(playerDto);

            return NoContent();
        }
    }
}
