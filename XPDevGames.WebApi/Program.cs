using MediatR;
using XPDevGames.Application.UseCases.BoardUseCases.Add;
using XPDevGames.Application.UseCases.BoardUseCases.GetAll;
using XPDevGames.Application.UseCases.BoardUseCases.GetById;
using XPDevGames.Domain.Services;
using XPDevGames.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddTransient<IRequestHandler<BoardInputById, BoardOutput>, GetByIdBoardUseCase>();
builder.Services.AddTransient<IRequestHandler<BoardInputAll, List<BoardOutputAll>>, GetAllBoardUseCase>();
builder.Services.AddTransient < IRequestHandler<BoardInput, Unit>, AddBoardUseCase>();

builder.Services.AddTransient<IBoardRepository, BoardRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
