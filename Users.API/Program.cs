using Core.API;
using Core.Infra;
using Core.Infra.RepositoresEF;
using MediatR;
using Users.Model.Client;
using Users.Model.Manager;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndPointDefinitions(typeof(Program));
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddScoped<IClientRepository, ClientRepositoryEF>();
builder.Services.AddScoped<IManagerRepository, ManagerRepositoryEF>();
builder.ConfigureSqlServer<InfoInvestDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEndpointDefinitions();
app.Run();