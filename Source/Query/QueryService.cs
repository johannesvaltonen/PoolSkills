using System.Collections.Generic;

namespace PoolSkills.Query
{
    public class QueryService : IQueryService
    {
        public IReadOnlyCollection<string> GetValues()
        {
            return new List<string> { "Foo", "Bar" };
        }
    }
}