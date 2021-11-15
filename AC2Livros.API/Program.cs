using AC2Livros.API.ControllersConfiguration;
using Livros.Domain.Repositories;
using Livros.Infra;
using Livros.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationContext>(x => x.UseInMemoryDatabase("DataBase"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ILivroRepository, LivroRepository>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.ApplyControllers();
app.Run();