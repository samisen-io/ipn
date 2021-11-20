using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using server.DataContext;
using server.Handlers;
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
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IMediaService, MediaService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IPostCategoryService, PostCategoryService>();
builder.Services.AddScoped<IPostMetaService, PostMetaService>();
builder.Services.AddScoped<IPostCommentService, PostCommentService>();


builder.Services.AddDbContextPool<AppDBContext>(options => options
      .UseMySql(Configuration.GetConnectionString("DefaultConnection"),
          ServerVersion.Create(new Version(10, 5, 4), ServerType.MariaDb))
  );

builder.Services.AddAuthentication("BasicAuthentication")
            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
 

// configure DI for application services
builder.Services.AddScoped<IUserService, UserService>();



var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
