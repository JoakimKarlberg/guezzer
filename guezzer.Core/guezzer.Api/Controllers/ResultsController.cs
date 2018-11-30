using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using guezzer.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        //PUT: api/Results/playerName+categoryType
        [HttpPut("{playerName}+{categoryType}")]
        public async Task<IActionResult> Add([FromRoute]string playerName, [FromRoute]string categoryType)
        {
            return Ok(await _repository.Add(playerName, categoryType));
        }
    }
}
