using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PostgreSqlExample.Data;
using System.Configuration;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using tasinmaz.Models;
using tasinmaz.Data;

var builder = WebApplication.CreateBuilder(args);
var key = Encoding.ASCII.GetBytes(builder.Configuration.GetSection("Appsettings:Token").Value);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<DbContext>(provider => provider.GetService<PostgreSqlExampleDbContext>());
//builder.Services.AddDbContext<PostgreSqlExampleDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("tasinmaz"), b => b.MigrationsAssembly("tasinmaz")));
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("tasinmaz"), b => b.MigrationsAssembly("tasinmaz")));

builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IAppRepository, AppRepository>();

//builder.Services.AddScoped<DataContext>(provider => provider.GetService<DataContext>());
//builder.Services.AddScoped<DataContext>();

//builder.Services.AddTransient<IAuthRepository, AuthRepository>();
//builder.Services.AddTransient<IAppRepository, AppRepository>();

//builder.Services.AddSingleton<IAuthRepository, AuthRepository>();
//builder.Services.AddSingleton<IAppRepository, AppRepository>();

builder.Services.AddCors();

builder.Services.AddAutoMapper(typeof(Tasinmaz));
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
