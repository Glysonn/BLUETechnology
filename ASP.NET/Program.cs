using Microsoft.EntityFrameworkCore;
using ProcessoSeletivoBLUE.Context;


var builder = WebApplication.CreateBuilder(args);

// configurando o CORS para permitir as requisições do frontend

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.WithOrigins("http://localhost:8080")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});


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


app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
