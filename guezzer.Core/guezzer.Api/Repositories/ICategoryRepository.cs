using guezzer.Entities;
using System.Collections;

namespace guezzer.Api.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable GetAll();

        Category Get(string type);
    }
}
