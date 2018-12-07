using guezzer.Api.Helpers;
using guezzer.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<PlayerDto>> GetAll();

        Task<PlayerDto> Get(string name);

        Task<Player> Update(PlayerDto playerDto);
    }
}
