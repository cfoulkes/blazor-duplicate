using BlazorDuplicate.Api.Data;
using BlazorDuplicate.Api.Repositories;
using BlazorDuplicate.Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionString"]);
});
builder.Services.AddScoped<UnitOfWork>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<ClientPersonService>();
builder.Services.AddScoped<ClientPersonRepository>();

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
