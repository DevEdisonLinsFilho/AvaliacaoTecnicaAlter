using Db.Context;
using Db.Repositories.Contracts;
using Db.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using Service.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();

builder.Services.AddDbContext<AvaliacaoTecnicaContext>(
    options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("MyConnection"),
            x => x.MigrationsAssembly("AvaliacaoTecnica")));

//Dependency Injection
builder.Services.AddAutoMapper(typeof(Program));

//Scoped
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();