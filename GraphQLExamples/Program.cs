using GraphQL;
using GraphQL.SystemTextJson;
using GraphQL.Types;
using GraphQLExamples;

var schema = Schema.For(@"
  type Droid {
    id: ID
    name: String
  }

  type Query {
    droid(id: ID): Droid
  }
", _ =>
{
    _.Types.Include<Query>();
});

var json = await schema.ExecuteAsync(_ =>
{
    _.Query = $"{{ droid(id: \"123\") {{ id name }} }}";
});

Console.WriteLine(json);