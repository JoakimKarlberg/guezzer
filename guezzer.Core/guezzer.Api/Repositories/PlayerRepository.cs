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

        public async Task<PlayerDto> Get(string name)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Name == name);

            if (player == null)
            {
                return null;
            }

            var playerDto = new PlayerDto { Name = player.Name, TimesPlayed = player.TimesPlayed };            

            return playerDto;
        }

        public async Task<List<PlayerDto>> GetAll()
        {
            var players = await _context.Players.ToListAsync();

            if (players == null)
            {
                // Exception handler
                return null;
            }

            var playerDtos = new List<PlayerDto>();

            foreach(var player in players)
            {
                playerDtos.Add(new PlayerDto { Name = player.Name, TimesPlayed = player.TimesPlayed });
            }

            return playerDtos;
        }

        public async Task<Player> Update(PlayerDto playerDto)
        {
            var player = await _context.Players.FirstOrDefaultAsync(p => p.Name == playerDto.Name);

            if(player == null)
            {
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
