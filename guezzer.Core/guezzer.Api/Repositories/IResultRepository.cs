using guezzer.Api.Helpers;
using guezzer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace guezzer.Api.Repositories
{
    public interface IResultRepository
    {
        Task<List<GetResultDto>> GetAll();

        Task<Result> Update(ResultDto resultDto);
    }
}
