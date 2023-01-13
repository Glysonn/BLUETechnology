using Microsoft.EntityFrameworkCore;
using ProcessoSeletivoBLUE.Context;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// adicionando o banco em memória do entity framework na API
builder.Services.AddDbContext<AgendaContext> (options => options.UseInMemoryDatabase("Agenda"));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
