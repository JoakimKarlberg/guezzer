using guezzer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface IResultRepository
    {
        Task<IEnumerable<Result>> GetAll();

        Task<Result> Add(string playerName, string categoryType);
    }
}
