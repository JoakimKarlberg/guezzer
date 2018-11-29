using System;
using guezzer.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetAll()
        {
            var result = _repository.GetAll();

            return Ok(result);
        }

        // GET: api/Categories/Music
        [HttpGet("{type}")]
        public ActionResult Get(string type)
        {
            return Ok(_repository.Get(type));
        }
    }
}
