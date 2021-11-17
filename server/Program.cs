using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using server.DataContext;
using server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IConfiguration Configuration = new ConfigurationBuilder()
   .AddJsonFile("appsettings.json", true, true)
   .Build();

builder.Services.AddSingleton<IConfiguration>(Configuration);
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContextPool<UserDBContext>(options => options
      .UseMySql(Configuration.GetConnectionString("DefaultConnection"),
          ServerVersion.Create(new Version(10, 5, 4), ServerType.MariaDb))
  );

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
