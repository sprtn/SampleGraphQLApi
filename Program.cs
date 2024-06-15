using GraphQLApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGet("/health", () => "Up!");
app.MapGet("/", () => "Hello. Use /graphql to enter Banana cake pop tool!");
app.MapGet("/whois", () => "Vegard Pihl Bratteng");

app.MapGraphQL();
app.Run();
 