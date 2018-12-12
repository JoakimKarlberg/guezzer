using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();

        Task<T> Get(string input);
    }
}
