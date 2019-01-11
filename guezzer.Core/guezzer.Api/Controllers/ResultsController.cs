using System;
using System.Threading.Tasks;
using guezzer.Api.Helpers;
using guezzer.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Serilog;

namespace guezzer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly IResultRepository _resultRepository;
        private readonly IPlayerRepository _playerRepository;

        public ResultsController(IResultRepository resultRepository, IPlayerRepository playerRepository)
        {
            _resultRepository = resultRepository;
            _playerRepository = playerRepository;
        }

        //GET: api/Results
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            Log.Logger.Information($"Requesting GetAll from Results");

            var results = await _resultRepository.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        //GET: api/results/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetResultById(string id)
        {
            Log.Logger.Information($"Requesting {id} from Results");

            if (id == null)
            {
                return BadRequest();
            }

            var result = await _resultRepository.Get(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //GET: api/results/player/{name}
        [HttpGet("player/{name}")]
        public async Task<IActionResult> GetPlayerResults(string name)
        {
            Log.Logger.Information($"Requesting {name} from Results");

            if (name == null)
            {
                return BadRequest();
            }

            var result = await _resultRepository.GetPlayerResults(name);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        //PUT: api/results/{resultDto-object}
        //[HttpPut]
        //public async Task<IActionResult> Update([FromBody] UpdateResultDto resultDto)
        //{

        //    Log.Logger.Information($"Updating {resultDto.Name} in Results");

        //    if (resultDto == null)
        //    {
        //        return BadRequest();
        //    }

        //    if (!(resultDto.Score >= 0))
        //    {
        //        ModelState.AddModelError(nameof(UpdateResultDto), "Score needs to be a number of value 0 or higher.");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return new UnprocessableEntityObjectResult(ModelState);
        //    }

        //    var result = await _resultRepository.Update(resultDto);

        //    return NoContent();
        //}

        //PUT: api/results/{playerResultDto}
        [HttpPut]
        public async Task<IActionResult> UpdatePlayerAndResult([FromBody] UpdatePlayerResultDto updatePlayerResultDto)
        {
            Log.Logger.Information($"Updating {updatePlayerResultDto.Name} with Result {updatePlayerResultDto.Score} in Category: {updatePlayerResultDto.Category}");

            if(updatePlayerResultDto == null)
            {
                return BadRequest();
            }

            if(!(updatePlayerResultDto.Score >= 0))
            {
                ModelState.AddModelError(nameof(UpdateResultDto), "Score needs to be a number of value 0 or higher.");
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var player = GetPlayerFromUpdatePlayerResultDto(updatePlayerResultDto);   
            var playerUpdateResult = await _playerRepository.Update(player);

            Log.Logger.Information($"{player.Name} updated");

            var result = GetResultFromUpdatePlayerResultDto(updatePlayerResultDto);
            var scoreUpdateResult = await _resultRepository.Update(result);

            Log.Logger.Information($"Result with score {result.Score} updated");
            Log.Logger.Information($"{player.Name} successfully updated with result {result.Score} in Category: {result.Category}");

            return NoContent();
        }

        // Returns a single playerDto from UpdatePlayerResultDto
        private UpdatePlayerDto GetPlayerFromUpdatePlayerResultDto(UpdatePlayerResultDto player)
        {
            var updatePlayerDto = new UpdatePlayerDto { Name = player.Name };
            return updatePlayerDto;
        }

        // Returns a single resultDto from UpdatePlayerResultDto
        private UpdateResultDto GetResultFromUpdatePlayerResultDto(UpdatePlayerResultDto result)
        {
            var updateResultDto = new UpdateResultDto { Name = result.Name, Category = result.Category, Score = result.Score };
            return updateResultDto;
        }
    }
}