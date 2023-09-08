using System.Reflection;
using AspNetCoreRateLimit;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using Microsoft.AspNetCore.Authentication.JwtBearer;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.RespectBrowserAcceptHeader = true;
    options.ReturnHttpNotAcceptable = true;
}).AddXmlSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.ConfigureCors();
builder.Services.AddSwaggerGen(c => 
{
    c.ResolveConflictingActions( apiDescriptions => apiDescriptions.First()); 
});
// builder.Services.AddAplicacionServices();
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
// builder.Services.ConfigureRateLimiting();
// builder.Services.AddJwt(builder.Configuration);
// builder.Services.ConfigureApiVersioning();

builder.Services.AddDbContext<TallerContext>(options => 
{
   string connectionString = builder.Configuration.GetConnectionString("ConexMySql");
   options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)); 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using(var scope= app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try
    {
        var context = services.GetRequiredService<TallerContext>();
        await context.Database.MigrateAsync();
    }
    catch(Exception ex)
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(ex, "Ocurrió un error durante la migración");
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

// app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();

// app.UseIpRateLimiting();
