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
            var result = await _context.Results.FirstOrDefaultAsync(r => r.Player.Name == resultDto.PlayerName && r.Category.Type == resultDto.CategoryType);

            if (result == null)
            {
                var newResult = new Result
                {
                    Id = Guid.NewGuid(),
                    Category = await _context.Categories.FirstOrDefaultAsync(c => c.Type == resultDto.CategoryType),
                    Player = await _context.Players.FirstOrDefaultAsync(p => p.Name == resultDto.PlayerName),
                    Score = resultDto.Score,
                    Updated = DateTime.Now
                };

                await _context.Results.AddAsync(newResult);
            }
            else
            {
                result.Score = resultDto.Score; // Should not update score if the new score is lower than previous highscore
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
