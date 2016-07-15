using System.Collections.Generic;

namespace PoolSkills.Query
{
    public interface IQueryService
    {
        IReadOnlyCollection<string> GetValues();
    }
}