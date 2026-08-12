
using Day38_EF_SampleApplication.Data;
using Day38_EF_SampleApplication.Repository;
using Microsoft.EntityFrameworkCore;

namespace Day38_EF_SampleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Read Connection String from appsetting.json
            
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // register app db context
            builder.Services.AddDbContext<AppDbContext> (options => options.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}
