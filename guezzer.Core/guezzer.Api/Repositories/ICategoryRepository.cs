using guezzer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();

        Task<Category> Get(string type);
    }
}
