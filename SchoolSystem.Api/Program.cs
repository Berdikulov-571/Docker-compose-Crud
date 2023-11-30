using AppartmentSystem.DataAccess.DataContexts;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Service.Interfaces;
using SchoolSystem.Service.Services;

namespace SchoolSystem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Docker")));

            builder.Services.AddScoped<ITeacherRepository, TeacherService>();
            builder.Services.AddScoped<IClassRepository, ClassService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
