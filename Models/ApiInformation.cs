namespace GraphQLApi.Models
{
    public class ApiInformation
    {
        public DateTime CurServerTime => DateTime.Now;
        public string Name { get; set; }

        private readonly string creator = "Vegard";

        public ApiInformation(string? name) 
        { 
            this.Name = string.IsNullOrEmpty(name) ? this.creator : name; 
        }
    }
}
