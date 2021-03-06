﻿using guezzer.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Threading.Tasks;

namespace guezzer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _repository;

        public CategoriesController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Categories/
        public async Task<IActionResult> GetAll()
        {
            Log.Logger.Information("Requesting GetAll from Categories");
            
            var result = await _repository.GetAll();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/Categories/Music
        [HttpGet("{type}")]
        public async Task<IActionResult> Get(string type)
        {
            Log.Logger.Information($"Requesting {type} from Categories");
            var result = await _repository.Get(type);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
