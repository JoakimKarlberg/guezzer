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

        public async Task<List<GetResultDto>> GetAll()
        {
            var results = await _context.Results
                .Include(p => p.Player)
                .Include(c => c.Category)
                .ToListAsync();

            var getResultDtos = new List<GetResultDto>();

            foreach (var result in results)
            {
                getResultDtos.Add(new GetResultDto
                {
                    ResultId = result.Id,
                    Name = result.Player.Name,
                    Category = result.Category.Type,
                    Score = result.Score
                });
            }

            if(getResultDtos == null)
            {
                //handle exception
                return null;
            }

            return getResultDtos;
        }

        public async Task<Result> Update(UpdateResultDto resultDto)
        {
            var result = await _context.Results.FirstOrDefaultAsync(r => r.Player.Name == resultDto.Name && r.Category.Type == resultDto.Category);

            if (result == null)
            {
                // Add function that creates instead of having it nested in an Update function - repository pattern
                var newResult = new Result
                {
                    Id = Guid.NewGuid(),
                    Category = await _context.Categories.FirstOrDefaultAsync(c => c.Type == resultDto.Category),
                    Player = await _context.Players.FirstOrDefaultAsync(p => p.Name == resultDto.Name),
                    Score = resultDto.Score,
                    Updated = DateTime.Now
                };

                result = newResult;
                await _context.Results.AddAsync(result);
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
    }
}
