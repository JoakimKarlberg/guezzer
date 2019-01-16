using guezzer.Api.Helpers;
using guezzer.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface IResultRepository : IRepository<GetResultDto>
    {
        Task<Result> Update(UpdateResultDto resultDto);

        Task<List<GetResultDto>> GetPlayerResults(string name);

        Task<Guid> GetPlayerIdByName(string name);
    }
}
