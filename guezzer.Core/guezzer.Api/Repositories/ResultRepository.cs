using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using guezzer.Api.Helpers;
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

        public async Task<Result> Update(ResultDto resultDto)
        {
            var result = await _context.Results.FirstOrDefaultAsync(r => r.Player.Name == resultDto.Name && r.Category.Type == resultDto.Category);

            if (result == null)
            {
                var newResult = new Result
                {
                    Id = Guid.NewGuid(),
                    Category = await _context.Categories.FirstOrDefaultAsync(c => c.Type == resultDto.Category),
                    Player = await _context.Players.FirstOrDefaultAsync(p => p.Name == resultDto.Name),
                    Score = resultDto.Score,
                    Updated = DateTime.Now
                };

                await _context.Results.AddAsync(newResult);
            }
            else
            {
                if (resultDto.Score > result.Score)
                {
                    result.Score = resultDto.Score;
                }
                result.Updated = DateTime.Now;

                _context.Results.Update(result);
            }

            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<IEnumerable<Result>> GetAll()
        {
            var results = await _context.Results.ToListAsync();

            if (results == null)
            {
                // Implement null handler
                return null;
            }

            return results;
        }
    }
}
