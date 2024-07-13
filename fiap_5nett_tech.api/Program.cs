using fiap_5nett_tech.Application.Interface;
using fiap_5nett_tech.Application.Service;
using Microsoft.EntityFrameworkCore;
using fiap_5nett_tech.Infrastructure.Data;


var builder = WebApplication.CreateBuilder(args);

//public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<IContactInterface, ContactService>();

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