namespace GraphQLApi.Models
{
    public class Query
    {
        public string Hello() => "Hello World!";
         
        public ApiInformation GetTimestamp(string? name) => new(name);
    }
}
