using Assets;
using Assets.Infra;
using Core.API;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndPointDefinitions(typeof(Program));
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddScoped<IAssetRepository, AssetRepositoryEF>();
builder.ConfigureSqlServer<AssetsDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseEndpointDefinitions();
app.Run();