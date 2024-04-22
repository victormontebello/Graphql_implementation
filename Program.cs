using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLExemplo.Context;
using GraphQLExemplo.Interface;
using GraphQLExemplo.Query;
using GraphQLExemplo.Schema;
using GraphQLExemplo.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<ISchema, MenuSchema>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

var app = builder.Build();
app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
