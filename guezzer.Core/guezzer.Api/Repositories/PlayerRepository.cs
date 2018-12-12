using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using guezzer.Api.Helpers;
using guezzer.Data;
using guezzer.Entities;
using Microsoft.EntityFrameworkCore;

namespace guezzer.Api.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly GuezzerDbContext _context;

        public PlayerRepository(GuezzerDbContext context)
        {
            _context = context;
        }

        public async Task<GetPlayerDto> Get(string name)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Name == name);

            if (player == null)
            {
                return null;
            }

            var playerDto = new GetPlayerDto { Name = player.Name, TimesPlayed = player.TimesPlayed };            

            return playerDto;
        }

        public async Task<List<GetPlayerDto>> GetAll()
        {
            var players = await _context.Players.ToListAsync();

            if (players == null)
            {
                // Exception handler
                return null;
            }

            var playerDtos = new List<GetPlayerDto>();

            foreach(var player in players)
            {
                playerDtos.Add(new GetPlayerDto { Name = player.Name, TimesPlayed = player.TimesPlayed });
            }

            return playerDtos;
        }

        public async Task<Player> Update(UpdatePlayerDto playerDto)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Name == playerDto.Name);

            if(player == null)
            {
                // Add function that creates instead of having it nested in an Update function - repository pattern
                var newPlayer = new Player
                {
                    Id = Guid.NewGuid(),
                    Name = playerDto.Name,
                    TimesPlayed = 1
                };
                await _context.Players.AddAsync(newPlayer);
            }
            else
            {
                player.TimesPlayed += 1;
                _context.Players.Update(player);
            }

            await _context.SaveChangesAsync();

            return player;
        }
    }
}
