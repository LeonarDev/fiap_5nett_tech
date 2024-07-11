using fiap_5nett_tech.api;
using fiap_5nett_tech.api.Data;
using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Application.Service;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(Environment.GetEnvironmentVariable("DefaultConnection"))); 
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<ContactInterface, ContactService>();

builder.Services.AddControllers();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();