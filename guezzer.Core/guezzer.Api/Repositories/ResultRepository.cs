using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using guezzer.Data;
using guezzer.Entities;
using Microsoft.EntityFrameworkCore;

namespace guezzer.Api.Repositories
{
    public class ResultRepository : IResultRepository
    {
        private readonly GuezzerDbContext _context;

        public ResultRepository(GuezzerDbContext context)
        {
            _context = context;
        }

        public async Task<Result> Add(string playerName, string categoryType)
        {
            var result = await _context.Results.FirstOrDefaultAsync(r => r.Player.Name == playerName && r.Category.Type == categoryType);

            if (result == null)
            {
                await _context.Results.AddAsync(result);
            }
            else
            {
                _context.Results.Update(result);
            }

            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<Result>> GetAll()
        {
            var results = await _context.Results.ToListAsync();

            if(results == null)
            {
                // Implement null handler
                return null;
            }

            return results;
        }
    }
}
