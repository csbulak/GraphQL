using System;
using GraphQL;

namespace GraphQLExamples
{
    public class Query
    {
        public Query()
        {
        }

        private List<Droid> _droids = new List<Droid>
          {
            new Droid { Id = "123", Name = "R2-D2" }
          };

        [GraphQLMetadata("droid")]
        public Droid GetDroid(string id)
        {
            return _droids.FirstOrDefault(x => x.Id == id);
        }
    }
}

