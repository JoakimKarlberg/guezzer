using guezzer.Api.Helpers;
using guezzer.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface IPlayerRepository : IRepository<GetPlayerDto>
    {
        Task<Player> Update(UpdatePlayerDto playerDto);
    }
}
