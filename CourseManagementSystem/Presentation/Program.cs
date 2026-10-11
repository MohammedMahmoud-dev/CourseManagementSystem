using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Application.Features.Students.Commands.RegisterStudent;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
using CourseManagementSystem.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Reflection;


namespace CourseManagementSystem.Presentation
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //inject dbcontext
            //Ensure that the DbContext is registered only once.

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Course Management API",
                    Version = "v1",
                    Description = "API documentation for the Course Management System"
                });
            });
            builder.Services.AddMediatR(typeof(RegisterStudentHandler).Assembly);
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddInfrastructureServices(builder.Configuration);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Course Management API v1");
                    options.RoutePrefix = string.Empty; // Open Swagger at root URL
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
