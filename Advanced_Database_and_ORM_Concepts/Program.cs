using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Advanced_Database_and_ORM_Concepts.Data;
var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("AdventureWorksContext");
builder.Services.AddDbContext<AdventureWorksContext>(options =>
{
    options.UseSqlServer(connectionString);
});
var app = builder.Build();
app.Run();