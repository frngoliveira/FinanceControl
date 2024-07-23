using FinanceControl.Application._1._4_SeedWork;
using FinanceControl.Infra._3._1_Context;
using FinanceControl.Infra.CrossCutting.Ioc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.RegisterServices();

        builder.Services.AddCors(options =>
        {
            string allowedHosts =
                builder.Configuration.GetSection(key: "CorsSettings:AllowedHosts").Value ?? string.Empty;

            options.AddDefaultPolicy(
                policy =>
                {
                    policy.WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
        });

        builder.Services.AddAutoMapper(typeof(AutomapperConfig));

        builder.Services.AddDbContext<FinanceControlContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("FinanceControl.Infrastructure")));

        builder.Services.AddSwaggerGen(options => options.SwaggerDoc("v1", new OpenApiInfo { Title = "FinanceControl.API", Version = "v1" }));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseCors();

        app.MapControllers();


        app.Run();
    }
}