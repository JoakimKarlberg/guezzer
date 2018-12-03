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

        public async Task<Player> Get(Guid id)
        {
            var player = _context.Players.FirstOrDefaultAsync(p => p.Id == id);

            if(player == null)
            {
                return null;
            }

            return await player;
        }

        public async Task<IEnumerable<Player>> GetAll()
        {
            var players = _context.Players.ToListAsync();

            if (players == null)
            {
                // Exception handler
                return null;
            }

            return await players;
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
