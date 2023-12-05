using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQL_Udemy.Data;
using GraphQL_Udemy.Interfaces;
using GraphQL_Udemy.Mutations;
using GraphQL_Udemy.Queries;
using GraphQL_Udemy.Schemas;
using GraphQL_Udemy.Services;
using GraphQL_Udemy.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<GraphQLDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("GraphQLDbConnectionString"));
});
builder.Services.AddSingleton<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<MenuItemType>();
builder.Services.AddTransient<MenuItemInputType>();
builder.Services.AddTransient<MenuItemQuery>();
builder.Services.AddTransient<MenuItemMutation>();
builder.Services.AddTransient<ISchema,MenuItemSchema>();

builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseGraphiQl("/graphQL");
app.UseGraphQL<ISchema>();
app.UseAuthorization();

app.MapControllers();

app.Run();
