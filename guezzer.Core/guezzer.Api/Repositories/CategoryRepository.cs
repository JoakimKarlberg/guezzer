using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<Category> Get(string type)
        {
            var category = _context.Categories.FirstOrDefaultAsync(c => c.Type == type);

            if(category == null)
            {
                // Exception handler
                return null;
            }

            return await category;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var categories = _context.Categories.ToListAsync();

            if (categories == null)
            {
                // Exception handler
                return null;
            }

            return await categories;
        }
    }
}
