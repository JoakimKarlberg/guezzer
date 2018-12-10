using guezzer.Api.Helpers;
using guezzer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<GetCategoryDto>> GetAll();

        Task<GetCategoryDto> Get(string type);
    }
}
