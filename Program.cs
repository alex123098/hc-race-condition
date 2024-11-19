using HotChocolate.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddGraphQL().AddTypes();

var app = builder.Build();

app.MapGraphQL().WithOptions(new GraphQLServerOptions
{
    EnableBatching = true
});

app.RunWithGraphQLCommands(args);