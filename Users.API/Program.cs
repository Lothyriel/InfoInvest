using Core.API;
using MediatR;
using Users.Infra;
using Users.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndPointDefinitions(typeof(Program));
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddScoped<IUserRepository, UserRepositoryEF>();
builder.ConfigureSqlServer<UsersDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEndpointDefinitions();
app.Run();