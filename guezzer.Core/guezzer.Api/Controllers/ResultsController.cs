using System;
using System.Threading.Tasks;
using guezzer.Api.Helpers;
using guezzer.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace guezzer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly IResultRepository _repository;

        public ResultsController(IResultRepository repository)
        {
            _repository = repository;
        }

        //GET: api/Results
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var results = await _repository.GetAll();
            return Ok(results);
        }

        //PUT: api/Results/{resultDto-object}
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateResultDto resultDto)
        {
            if (resultDto == null)
            {
                return BadRequest();
            }

            if(!(resultDto.Score >= 0))
            {
                ModelState.AddModelError(nameof(UpdateResultDto), "Score needs to be a number of value 0 or higher.");
            }

            if (!ModelState.IsValid)
            {
                return new UnprocessableEntityObjectResult(ModelState);
            }

            var result = await _repository.Update(resultDto);

            return NoContent();
        }
    }
}