using System.Collections.Generic;
using System.Threading.Tasks;
using guezzer.Api.Helpers;
using guezzer.Data;
using guezzer.Entities;
using Microsoft.EntityFrameworkCore;

namespace guezzer.Api.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly GuezzerDbContext _context;

        public CategoryRepository(GuezzerDbContext context)
        {
            _context = context;
        }

        public async Task<GetCategoryDto> Get(string type)
        {
            var category = await _context.Categories
                .FirstOrDefaultAsync(c => c.Type == type);

            if(category == null)
            {
                // Exception handler
                return null;
            }

            var categoryDto = new GetCategoryDto { Id = category.Id, Type = category.Type };

            return categoryDto;
        }

        public async Task<List<GetCategoryDto>> GetAll()
        {
            var categories = await _context.Categories
                .ToListAsync();

            if (categories == null)
            {
                // Exception handler
                return null;
            }

            var categoryDtos = new List<GetCategoryDto>();

            foreach(var item in categories)
            {
                categoryDtos.Add(new GetCategoryDto { Id = item.Id, Type = item.Type });
            }

            return categoryDtos;
        }
    }
}