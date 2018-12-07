using guezzer.Api.Helpers;
using guezzer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDto>> GetAll();

        Task<CategoryDto> Get(string type);
    }
}
